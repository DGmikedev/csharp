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
            cronometro();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to my App!");
        }

        public void cronometro()
        {

            int acm = 0;

            while (acm == 100) {
                MessageBox.Show("dfg");
                lbl1.Text = acm.ToString();
                acm++;
                Thread.Sleep(10000);
            }
        }


    }
}
