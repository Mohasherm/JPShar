using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPShar
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private JBSharEntities db;
        public bool isClose = true;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            db = new JBSharEntities();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (txtUserName.EditValue == null)
                {
                    MessageBox.Show("أدخل إسم المستخدم");
                    return;
                }
                if (txtPassword.EditValue == null)
                {
                    MessageBox.Show("أدخل كلمة السر");
                    return;
                }
                var user = await db.Sittings.FirstOrDefaultAsync();

                if (user.UserName.Equals(txtUserName.EditValue.ToString())
                    && user.Password.Equals(txtPassword.EditValue.ToString()))
                {
                    isClose = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("فشل في عملية تسجيل الدخول");
                    return;
                }
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
            isClose = true;
            Close();
        }
    }
}