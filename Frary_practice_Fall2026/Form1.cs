namespace Frary_practice_Fall2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTextInput.Clear();
            txtNumericInput.Clear();
            lstOut.Items.Clear();
        }
    }
}
