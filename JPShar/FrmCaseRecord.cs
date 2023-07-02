using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JPShar
{
    public partial class FrmCaseRecord : XtraForm
    {
        public FrmCaseRecord()
        {
            InitializeComponent();
        }
        private JBSharEntities db;
        private bool isAdmin = false;
        private void FrmCaseRecord_Load(object sender, EventArgs e)
        {

            FrmLogin log = new FrmLogin();
            log.ShowDialog();

            isAdmin = log.isAdmin;
            if (log.isClose)
            {
                Close();
                return;
            }
            db = new JBSharEntities();
            refreshGrid();

            if (isAdmin)
            {
                btnAdmin.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnAdminDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSitting.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }

            ColumnFilterInfo filter = new ColumnFilterInfo("[Date] between (#01 JAN 2016#, #01 DEC 2090#)", "");
            gridView1.ActiveFilter.Add(Date, filter);
            Date.OptionsFilter.AllowFilter = true;
        }
        void refreshGrid()
        {
            gridControl1.DataSource = db.CaseRecords.OrderByDescending(x => x.Id).ToList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNewCaseRecord frm = new FrmNewCaseRecord(0);
            frm.ShowDialog();
            refreshGrid();
        }

        private void btnReNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNewCaseRecord frm = new FrmNewCaseRecord(1);
            frm.ShowDialog();
            refreshGrid();
        }

        private void btnLockYear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("هل أنت متأكد من قفل العام الحالي والبدء بعام جديد ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var data = db.Sittings.FirstOrDefault();
                data.Year++;
                db.SaveChanges();
            }
        }

        private void btnExportToExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dia = new SaveFileDialog();
            dia.Filter = "Excel Files (*.xlsx)|*.xlsx";
            var result = dia.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            gridControl1.ExportToXlsx(dia.FileName);
        }

        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string FilePath = "D:\\";
                string ErrorMessage;
                CreatBakup(FilePath + "\\" + "backup" + "." + DateTime.Now.Year + "." + DateTime.Now.Month + "." + DateTime.Now.Day + "." + DateTime.Now.Hour + "." + DateTime.Now.Minute + ".bak", "JBShar", out ErrorMessage);

                if (ErrorMessage == "")
                    MessageBox.Show("تمت العلية بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(ErrorMessage, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public void CreatBakup(string FilePath, string dbName, out string ErrorMessage)
        {
            //NOINIT = نسخة تراكمية
            string cmd_txt = string.Format("backup Database {0} to Disk = '{1}'  with  DESCRIPTION = '{0}', name = '{0}', INIT" + ", COMPRESSION", dbName, FilePath);

            try
            {
                var a = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, cmd_txt);
                ErrorMessage = "";
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            finally
            {

            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var selectedrows = gridView1.GetSelectedRows();
            if (selectedrows.Count() == 0 || selectedrows[0] < 0)
            {
                XtraMessageBox.Show("الرجاء اختيار دعوى أولاً", "تنبيه");
                return;
            }

            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Id));
            FrmAddDecesionNum frm = new FrmAddDecesionNum(id);
            frm.ShowDialog();
            db = new JBSharEntities();
            refreshGrid();
        }

        private void btnAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedrows = gridView1.GetSelectedRows();
            if (selectedrows.Count() == 0 || selectedrows[0] < 0)
            {
                XtraMessageBox.Show("الرجاء اختيار دعوى أولاً", "تنبيه");
                return;
            }

            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Id));
            FrmEditCaseRecordAdmin frm = new FrmEditCaseRecordAdmin(id);
            frm.ShowDialog();
            db = new JBSharEntities();
            refreshGrid();
        }

        private void btnAdminDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedrows = gridView1.GetSelectedRows();
            if (selectedrows.Count() == 0 || selectedrows[0] < 0)
            {
                XtraMessageBox.Show("الرجاء اختيار دعوى أولاً", "تنبيه");
                return;
            }

            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Id));
            var data = db.CaseRecords.Find(id);
            db.CaseRecords.Remove(data);
            db.SaveChanges();
            XtraMessageBox.Show("تم الحذف بنجاح");
            refreshGrid();
        }

        private void btnSitting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSitting frm = new FrmSitting();
            frm.ShowDialog();
        }
    }
}