namespace WinFormsApp1
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string className = txtClass.Text;

            int fee = int.Parse(txtFee.Text);
            int libfee = int.Parse(txtLibraryFee.Text);

            int total = fee + libfee;

            string sentence = "Name: \t" + name 
                +"\n Class:\t" + className
                +"\n Total Fee:\t"+ total;

            MessageBox.Show(
                text: sentence,
                caption: "Some Caption",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Exclamation
                );
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmDetail frmDetail = new frmDetail();
            frmDetail.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClass.Clear();
            txtName.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
