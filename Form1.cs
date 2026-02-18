namespace DemoWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnShowHelp.Text = "Show Help";
            btnShowHelp.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnShowHelp.Enabled = true;
            MessageBox.Show("Buttons Enabled!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to my App!");
        }
    }
}
