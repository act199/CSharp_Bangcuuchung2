namespace CSharp_Bangcuuchung2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtso.Text);
            for (int i = 1; i <= 10; i++)
            {
                lblketqua.Text += Environment.NewLine + so.ToString() + " x " + i.ToString() + " = " + (so * i).ToString();
            }
        }

        private void nudso_ValueChanged(object sender, EventArgs e)
        {
                txtso.Text = nudso.Value.ToString();
            }
        }
    }

