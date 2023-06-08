﻿using DevExpress.XtraEditors;
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

        private void FrmCaseRecord_Load(object sender, EventArgs e)
        {

            FrmLogin log = new FrmLogin();
            log.ShowDialog();

            if (log.isClose)
            {
                Close();
                return;
            }
            db = new JBSharEntities();
            refreshGrid();


            ColumnFilterInfo filter = new ColumnFilterInfo("[Date] between (#01 JAN 2016#, #01 DEC 2090#)", "");
            gridView1.ActiveFilter.Add(Date, filter);
            Date.OptionsFilter.AllowFilter = true;
        }
        void refreshGrid()
        {
            gridControl1.DataSource = db.CaseRecords.ToList();
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
            dia.ShowDialog();
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
                XtraMessageBox.Show("الرجاء اختيار دعوى أولاً","تنبيه");
                return; 
            }

            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Id));
            FrmAddDecesionNum frm = new FrmAddDecesionNum(id);
            frm.ShowDialog();
            db = new JBSharEntities();
            refreshGrid();
        }
    }
}