using ProjetoLogin.Apresentacao;

namespace ProjetoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Centraliza o formulário na tela
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
