using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordValidator
{
    public partial class frmPasswordValidator : Form
    {
        public frmPasswordValidator()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            var fullName = txtFullName.Text.Split(null);
            string firstName = fullName[0];
            string lastName = fullName[1];
            bool hasSymbol = pass.Any(char.IsPunctuation);
            bool hasUpperCase = pass.Any(char.IsUpper);
            bool hasNumber = pass.Any(char.IsNumber);
            bool hasSpaces = pass.Any(char.IsWhiteSpace);
            bool hasUsername = pass.Contains(txtUsername.Text);
            bool hasFirst = pass.Contains(firstName);
            bool hasLast = pass.Contains(lastName);

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Your password length must be 8 or more characters.");
            }
            else if(hasUpperCase == false)
            {
                MessageBox.Show("Your password must include at least one upper case letter.");
            }
            else if(hasNumber == false)
            {
                MessageBox.Show("Your password must include at least one number.");
            }
            else if(hasSpaces == true)
            {
                MessageBox.Show("Your password cannot have any spaces.");
            }
            else if(hasSymbol == false)
            {
                MessageBox.Show("Your password must have one special character.");
            }
            else if(hasUsername == true)
            {
                MessageBox.Show("Your password cannot contain your username.");
            }
            else if (hasFirst == true)
            {
                MessageBox.Show("Your password cannot contain your first name.");
            }
            else if (hasLast == true)
            {
                MessageBox.Show("Your password cannot contain your last name.");
            }
            else
            {
                MessageBox.Show("OK");
            }
            
            
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
