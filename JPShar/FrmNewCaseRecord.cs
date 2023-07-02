using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JPShar
{
    public partial class FrmNewCaseRecord : XtraForm
    {
        public FrmNewCaseRecord(int Id)
        {
            InitializeComponent();
            id = Id;
        }
        private JBSharEntities db;
        private readonly int id;
        int year;
        private void FrmNewCaseRecord_Load(object sender, EventArgs e)
        {
            db = new JBSharEntities();

            cmbType.Properties.DataSource = db.CaseRecords.Select(x => x.Type).Distinct().ToList();

            year = db.Sittings.FirstOrDefault().Year;
            int? maxNum = db.CaseRecords.Where(x => x.Date.Value.Year == year).Max(x => x.CaseNum);
            if (maxNum == null)
                txtCaseNum.EditValue = 1;
            else
                txtCaseNum.EditValue = maxNum + 1;

            if (id > 0)
            {
                cmbType.Enabled = false;
                cmbType.Properties.ReadOnly = true;
                cmbType.EditValue = "تجديد";
                this.Text = "تجديد دعوى";
            }
            else
            {
                numRoom.Enabled = false;
                numRoom.Properties.ReadOnly = true;
                numRoom.EditValue = "0";
                layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPerson1.EditValue == null)
            {
                XtraMessageBox.Show("أدخل المدعى");
                return;
            }
            if (txtPerson2.EditValue == null)
            {
                XtraMessageBox.Show("أدخل المدعى عليه");
                return;
            }
            if (txtLawyer.EditValue == null)
            {
                XtraMessageBox.Show("أدخل الوكيل");
                return;
            }
            if (cmbType.EditValue == null)
            {
                XtraMessageBox.Show("أدخل نوع الدعوى");
                return;
            }
            if (id > 0)
            {
                if (txtNewNum.EditValue == null)
                {
                    XtraMessageBox.Show("أدخل رقم اساس الدعوى القديمة");
                    return;
                }
                if (txtYeaR.EditValue == null)
                {
                    XtraMessageBox.Show("أدخل العام");
                    return;
                }
            }
                try
            {
                Cursor = Cursors.WaitCursor;

                var data = new CaseRecord
                {
                    CaseNum = Convert.ToInt32(txtCaseNum.EditValue),
                    Person1 = txtPerson1.EditValue.ToString(),
                    Person2 = txtPerson2.EditValue.ToString(),
                    Lawyer = txtLawyer.EditValue.ToString(),
                    Type = cmbType.EditValue.ToString(),
                    Date = DateTime.UtcNow
                };

                if (id > 0)
                {
                    data.Type = "تجديد دعوى رقم أساس " + txtNewNum.EditValue.ToString() + " لعام " + txtYeaR.EditValue.ToString();
                    data.Room = Convert.ToInt32(numRoom.Value);
                }
                else
                {
                    data.Room = GenrateRoom();
                }
                db.CaseRecords.Add(data);
                db.SaveChanges();
                Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int GenrateRoom()
        {
            Random random = new Random();

            // get Rooms with Num of Count for each room
            var lstRoomCount = db.CaseRecords
                .Where(x => x.Date.Value.Year == year
                         && x.Date.Value.Month == DateTime.UtcNow.Month
                         && x.Room != null)
                .GroupBy(x => x.Room)
                .Select(x => new
                {
                    x.Key,
                    caseCount = x.Count()
                })
                .OrderBy(x => x.Key).ToList();

            ///get room with count 0
            List<int?> roomlst = new List<int?>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var room = roomlst.Where(x => !lstRoomCount.Select(s => s.Key).Contains(x))
                .Select(x => new
                {
                    Key = x,
                    caseCount = 0
                }).ToList();

            if (room.Count <= 5)
            {

                lstRoomCount = (from r in room
                                select new
                                {
                                    r.Key,
                                    r.caseCount,
                                }).Union(
                from rc in lstRoomCount
                select new
                {
                    rc.Key,
                    rc.caseCount,
                }).OrderBy(x => x.Key).ToList();
            }

            // check diff between room count and save it in list
            List<int> list = new List<int>();
            if (lstRoomCount.Count > 0)
            {
                for (int i = 0; i < lstRoomCount.Count; i++)
                {
                    for (int j = 0; j < lstRoomCount.Count; j++)
                    {
                        // same room
                        if (i == j)
                        {
                            continue;
                        }
                        var sub = lstRoomCount[i].caseCount - lstRoomCount[j].caseCount;

                        // check if result is negative
                        if (sub < 0)
                        {
                            sub *= -1;
                            if (sub >= 5) // check if diff more than 5 cases and assign room
                            {
                                list.Add((int)lstRoomCount[i].Key);
                            }
                        }
                        else
                        {
                            if (sub >= 5)
                            {
                                list.Add((int)lstRoomCount[j].Key);
                            }
                        }
                    }
                }
            }
            else
            {
                return random.Next(1, 10);
            }

            if (list.Count == 0) // check if there is no big diff generate random
            {
                return random.Next(1, 10);
            }
            else
            {
                //grouping num of reapeted min room
                var lstRoom = list.GroupBy(x => x)
                    .Select(x => new { x.Key, rCount = x.Count() })
                    .ToList();

                var max = lstRoom.Max(x => x.rCount);

                var RoomNum = lstRoom.Where(x => x.rCount == max)
                    .Select(x => x.Key).FirstOrDefault();
                return RoomNum;
            }

        }
    }
}