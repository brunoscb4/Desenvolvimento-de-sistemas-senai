namespace main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Show();
            this.Hide();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
