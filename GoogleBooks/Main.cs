using System;
using System.Windows.Forms;

namespace GoogleBooks
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Add(new View.UcPesquisa());
            View.UcFavoritos ucFavoritos = new View.UcFavoritos();
            ucFavoritos.Dock = DockStyle.Fill;
            pnlFavoritos.Controls.Add(ucFavoritos);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
