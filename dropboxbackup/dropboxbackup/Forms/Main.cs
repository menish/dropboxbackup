using System.Windows.Forms;

namespace dropboxbackup.Forms
{
    public partial class Main : Form
    {
        Directory directory;
        Option optionForm;
        
        public Main()
        {
            InitializeComponent();
            directory = new Directory();
            optionForm = new Option();
        }

        private void browse_Click(object sender, System.EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.ShowDialog();
                directory.Path = dialog.SelectedPath;
            }
        }

        private void Options_Click(object sender, System.EventArgs e)
        {
            optionForm.Show();
        }
    }
}
