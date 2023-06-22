using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPShar
{
    public partial class FrmEditCaseRecordAdmin : DevExpress.XtraEditors.XtraForm
    {
        private readonly int id;

        public FrmEditCaseRecordAdmin(int Id)
        {
            InitializeComponent();
            id = Id;
        }
        private JBSharEntities db;
        CaseRecord data;
        private void FrmEditCaseRecordAdmin_Load(object sender, EventArgs e)
        {
            db = new JBSharEntities();
            cmbType.Properties.DataSource = db.CaseRecords.Select(x => x.Type).Distinct().ToList();
            data = db.CaseRecords.Find(id);
            txtCaseNum.EditValue = data.CaseNum;
            txtPerson1.EditValue = data.Person1;
            txtPerson2.EditValue = data.Person2;
            txtLawyer.EditValue = data.Lawyer;
            cmbType.Text = data.Type;
            numRoom.EditValue = data.Room;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                data.CaseNum = Convert.ToInt32(txtCaseNum.EditValue);
                data.Person1 = txtPerson1.EditValue.ToString();
                data.Person2 = txtPerson2.EditValue.ToString();
                data.Lawyer = txtLawyer.EditValue.ToString();
                data.Type = cmbType.EditValue.ToString();
                data.Room = Convert.ToInt32(numRoom.Value);

                db.Entry(data).State = System.Data.Entity.EntityState.Modified;
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
    }
}