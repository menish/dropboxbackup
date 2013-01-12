using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace dropboxbackup.Forms
{
    public partial class Option : Form
    {
        List<TextBox> passwordTextBoxes;
        static string tickImage;
        static Bitmap tick;

        public Option()
        {
            InitializeComponent();
            passwordTextBoxes = new List<TextBox>();
            tickImage = "dropboxbackup.Resources.green_tick.png";
            tick = LoadImages();
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

        private void confirmPasswordTb_TextChanged(object sender, EventArgs e)
        {
            if (passwordTb.Text == "")
                return;

            if (passwordTb.Text != confirmPasswordTb.Text)
            {
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }

            pictureBox1.Image = tick;
        }

        static Bitmap LoadImages()
        {
            return new Bitmap(Assembly.GetEntryAssembly().
                                  GetManifestResourceStream(tickImage));
        }
    }
}
