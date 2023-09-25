using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZXing;

namespace otpTest
{

    public partial class FormLogin : Form
    {
        public static FormLogin instance;
        Model1 account = new Model1();
        public int check;

        public FormLogin()
        {
            InitializeComponent();
            instance = this;
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtMailUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin đăng nhập", "Thông báo");
            }
            else
            {
                string taiKhoan = txtMailUser.Text.Trim();
                string matKhau = txtPassword.Text.Trim();


                List<DataAccount> listaccounts = account.DataAccounts.ToList();

                DataAccount dt = listaccounts.FirstOrDefault(p => p.Email == taiKhoan);//Tìm người dùng theo email
                if (dt != null)// truy vấn xem người dùng có tồn tại trong CSDL chưa
                {
                    if (dt.MatKhau.Trim() == matKhau)//Kiểm tra mật khẩu của người dùng nhập vào
                    {
                        string uid = dt.UID.ToString();
                        MessageBox.Show("Đăng nhập thành công ", "Thông báo", MessageBoxButtons.OK);
                        FormIn4 frm2 = new FormIn4();
                        frm2.GetUid = uid;
                        this.Hide();
                        frm2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã nhập sai mật khẩu", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister rg = new FormRegister();
            rg.ShowDialog();
            rg.Show();
            this.Hide();
            this.Close();
        }

        private void linkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check = 1;
            FormOTP frm1 = new FormOTP();
            this.Hide();
            frm1.ShowDialog();
            this.Close();
        }
    }
}
