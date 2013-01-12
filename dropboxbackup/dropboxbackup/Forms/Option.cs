using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dropboxbackup.Forms
{
    public partial class Option : Form
    {
        List<TextBox> passwordTextBoxes;
  
        public Option()
        {
            InitializeComponent();
            passwordTextBoxes = new List<TextBox>();
        }

        private void AddPasswordTextBoxesToList()
        {
            passwordTextBoxes.Add(passwordTb);
            passwordTextBoxes.Add(confirmPasswordTb);
        }


        private void Option_Load(object sender, EventArgs e)
        {
            AddPasswordTextBoxesToList();
            ChangePasswordTextBoxState(false);
        }

        void ChangePasswordTextBoxState(bool state)
        {
            foreach (var passwordTextBox in passwordTextBoxes)
            {
                passwordTextBox.Enabled = state;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordEnable_CheckedChanged(object sender, EventArgs e)
        {
            ChangePasswordTextBoxState(PasswordEnable.Checked);
        }
    }
}
