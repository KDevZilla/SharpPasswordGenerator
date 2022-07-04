using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpPasswordGenerator
{
    public partial class FormGeneratePassword : Form
    {
        public FormGeneratePassword()
        {
            InitializeComponent();
        }

        private void frmGeneratePassword_Load(object sender, EventArgs e)
        {
            this.Initial();
        }

        private void Initial()
        {
           
        }
        private void GenPassword()
        {
            if (!Utility.IsNumeric(this.txtPasswordLength.Text))
            {
                MessageBox.Show("Password Lenth must be numeric between 6 to 32");
                return;
            }
            int PasswordLength = int.Parse(this.txtPasswordLength.Text);
            if (PasswordLength < 6 || PasswordLength > 32)
            {
                MessageBox.Show("Password Lenth must be numeric between 6 to 32");
                return;
            }

            String SpecialCharacter = this.txtSpecialCharacter.Text.Trim();
            if (SpecialCharacter.Length == 0 && chkSpecialCharacter.Checked)
            {
                MessageBox.Show("If you would like to include special character you have to enter at least one special character");
                return;
            }
            if (!Utility.IsNumeric(this.txtQuantity.Text))
            {
                MessageBox.Show("Quantity must be numeric between 1 to 50");
                return;

            }

            int Quantity = int.Parse(this.txtQuantity.Text);
            if (Quantity < 1 || Quantity > 50)
            {
                MessageBox.Show("Quantity must be numeric between 1 to 50");
                return;

            }
            PasswordProperties passwordProperties = new PasswordProperties();
            passwordProperties.IsIncludeUpperCase = chkUppercase.Checked;
            passwordProperties.IsIncludeLowerCase = chkLowercase.Checked;
            passwordProperties.IsIncludeNumber = chkNumber.Checked;
            passwordProperties.IsIncludeSymbol = chkSpecialCharacter.Checked;
            passwordProperties.IsExcludeCompromisePassword = chkNotIncludeCompromisedPassword.Checked;
            passwordProperties.PasswordLength = int.Parse(this.txtPasswordLength.Text);

            IRandom RandomMachine = new CryptoRandom();
            BuildPasswordProperties Build = new BuildPasswordProperties();
            String Reason = "";
            if (!Build.IsValidRule(passwordProperties, ref Reason))
            {
                MessageBox.Show(" Your condition is not valid::" + Reason);
                return;
            }

            GeneratePassword PasswordGenerator = null;
            if (passwordProperties.IsExcludeCompromisePassword)
            {
                PasswordGenerator = new GeneratePassword(passwordProperties, RandomMachine, SpecialCharacter, LookUp.CompromisedPasswordHsh);
            }
            else
            {
                PasswordGenerator = new GeneratePassword(passwordProperties, RandomMachine, SpecialCharacter);
            }
            int i;
            _GeneratedPassword = "";
            for (i = 1; i <= Quantity; i++)
            {
                if (i > 1)
                {
                    _GeneratedPassword = GeneratedPassword + Environment.NewLine;
                }
                _GeneratedPassword += PasswordGenerator.Genearte();
            }
            this.txtPasswordGenerated.Text = _GeneratedPassword;
        }
        private void buttonGenPassword_Click(object sender, EventArgs e)
        {
            try
            {
                this.GenPassword();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error ::" + ex.Message);
            }

        }
        private string _GeneratedPassword = "";
        public string GeneratedPassword
        {
            get
            {
                return _GeneratedPassword;
            }
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnCopytoClipboard_Click(object sender, EventArgs e)
        {
            if (this.txtPasswordGenerated.Text.Trim() == "")
            {
                MessageBox.Show("Please generate a password first");
            }
            try
            {
                Clipboard.SetText(this.txtPasswordGenerated.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error ::" + ex.Message);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.StartPosition = FormStartPosition.CenterParent;
            formabout.ShowDialog();

        }
    }
}
