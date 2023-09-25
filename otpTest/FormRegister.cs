using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace otpTest
{
    public partial class FormRegister : Form
    {
        public static FormRegister instance = new FormRegister();
        public string mail;
        public FormRegister()
        {
            InitializeComponent();
            instance = this;
        }
        Model1 account = new Model1();

        private void Register_Load(object sender, EventArgs e)
        {

        }
        public bool IsValidEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
            {

                return (false);
            }

        }
        public bool checkMail(string chkmail)
        {
          

            DataAccount dt = account.DataAccounts.FirstOrDefault(p => p.Email.Trim() == chkmail.Trim());


            //if (VerifyEmail(chkmail))
            //    return true;
            if (dt != null)
            {
                return true;
            }
            else
            {

                return false;
            }

        }
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            FormLogin.instance.check = -1;
            if (txtMailUser.Text != string.Empty && txtPassword.Text != string.Empty && txtNhapLaiMatKhau.Text != string.Empty && txtTenNguoiDung.Text != string.Empty)
            {
                if (txtPassword.Text == txtNhapLaiMatKhau.Text && IsValidEmail(txtMailUser.Text) && txtMailUser.Text.Contains("@") && !txtMailUser.Text.EndsWith("."))
                {
                    if (!checkMail(txtMailUser.Text))
                    {
                        
                        this.Close();
                        this.Hide();
                        FormOTP frm1 = new FormOTP();
                        frm1.Email = txtMailUser.Text.Trim();
                        frm1.Mk=txtPassword.Text.Trim();
                        frm1.Ten=txtTenNguoiDung.Text.Trim();
                        frm1.ShowDialog();
                        
                       
                    }
                    else
                        MessageBox.Show("Mail này đã được sử dụng!");
                }
                else
                    MessageBox.Show("Email hoặc mật khẩu sai định dạng!");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");

        }
    }
}
