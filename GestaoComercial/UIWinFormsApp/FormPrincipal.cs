namespace UIWinFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}