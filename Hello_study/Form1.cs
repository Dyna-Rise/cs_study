namespace Hello_study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HelloButtonClicked(object sender, EventArgs e)
        {
            this.helloLabel.Text = "Hello World!";
        }
    }
}
