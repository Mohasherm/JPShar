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
    public partial class FrmSitting : DevExpress.XtraEditors.XtraForm
    {
        public FrmSitting()
        {
            InitializeComponent();
        }
        private JBSharEntities db;
        Sitting Sitting;
        private void FrmSitting_Load(object sender, EventArgs e)
        {
            db = new JBSharEntities();
            Sitting = db.Sittings.FirstOrDefault();
            if (Sitting != null)
            {
                txtUserName.EditValue = Sitting.UserName;
                txtPassword.EditValue = Sitting.Password;
                txtYear.EditValue = Sitting.Year;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!db.Sittings.Any())
            {
                Sitting = new Sitting()
                {
                    UserName = txtUserName.EditValue.ToString(),
                    Password = txtPassword.EditValue.ToString(),
                    Year = Convert.ToInt32(txtYear.EditValue.ToString()),
                };
                db.Sittings.Add(Sitting);
            }
            else
            {
                Sitting.UserName = txtUserName.EditValue.ToString();
                Sitting.Password = txtPassword.EditValue.ToString();
                Sitting.Year = Convert.ToInt32(txtYear.EditValue.ToString());
            }
            db.SaveChanges();
            XtraMessageBox.Show("تم الحفظ بنجاح");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}