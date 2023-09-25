using System;
using System.Collections.Generic;

using System.Linq;
using System.Windows.Forms;
namespace otpTest
{
    public partial class FormIn4 : Form
    {
        Model1 account = new Model1();

        private string uid;
        public string GetUid
        {
            get { return uid; }
            set { uid = value; }
        }
        public FormIn4()
        {
            InitializeComponent();
        }


        private void FormIn4_Load(object sender, EventArgs e)
        {


            List<DataAccount> listaccounts = account.DataAccounts.ToList();

            DataAccount dt = listaccounts.FirstOrDefault(p => p.UID.ToString().Trim() == uid.ToString().Trim());//Tìm người dùng theo uid


            labName.Text = dt.TenNguoiDung.ToString();
            txtName.Text = labName.Text;
            txtName.Text = dt.TenNguoiDung.ToString();
            txtEmail.Text = dt.Email.ToString();


            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin frm3 = new FormLogin();
            this.Hide();
            frm3.ShowDialog();
            this.Close();
        }
    }
}
