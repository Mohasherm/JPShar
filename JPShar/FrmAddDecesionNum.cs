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
    public partial class FrmAddDecesionNum : DevExpress.XtraEditors.XtraForm
    {
        private readonly int id;
        private JBSharEntities db;
        public FrmAddDecesionNum(int Id)
        {
            InitializeComponent();
            id = Id;
        }

        private void FrmAddDecesionNum_Load(object sender, EventArgs e)
        {
            db = new JBSharEntities();
            var data = db.CaseRecords.Find(id);
            if (data is null)
            {
                XtraMessageBox.Show("لا يمكن الإضافة هناك خطأ في إختيار الدعوى", "تنبيه");
                Close();
            }

            txtDecesionNum.EditValue = data.CaseDecesionNum;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtDecesionNum.EditValue is null)
            {
                XtraMessageBox.Show("أدخل رقم القرار", "تنبيه");
                Close();
            }
            var data = db.CaseRecords.Find(id);

            data.CaseDecesionNum = Convert.ToInt32(txtDecesionNum.EditValue);
            db.SaveChanges();
            Close();
        }
    }
}