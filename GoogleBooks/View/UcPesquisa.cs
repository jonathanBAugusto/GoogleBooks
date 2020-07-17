using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GoogleBooks.Control;
using GoogleBooks.Model;

namespace GoogleBooks.View
{
    public partial class UcPesquisa : UserControl
    {
        private int page;
        private int totalItems = 0;
        public static FlowLayoutPanel flowPanel = null;
        public UcPesquisa()
        {
            InitializeComponent();
            setButtonVisibility(false);
        }
        ~UcPesquisa() 
        {
            flowPanel = null;
        }

        private void setButtonVisibility(bool visible) 
        {
            btnFirstPage.Visible = visible;
            btnPreviousPage.Visible = visible;
            btnNextPage.Visible = visible;
        }

        private void UcPesquisa_Load(object sender, EventArgs e)
        {
            UcLoadingPesquisa load = new UcLoadingPesquisa();
            pnlLoad.Controls.Add(load);
            pnlLoad.Visible = false;
            pnlFundo.Visible = true;

            page = 0;
            flowPanel = fpnlBooks;
        }
        private void setStatusButtons() 
        {
            if (page > 0)
            {
                btnFirstPage.Enabled = true;
                btnPreviousPage.Enabled = true;
            }
        }
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Enabled)
            {
                statusButtonBuscar(false);
                string search = txtPesquisa.Text;
                PesquisaController pesquisa = new PesquisaController();
                changeStatusSearchPanel(true);
                ItemsBook books = await pesquisa.getBooks(search, startIndex: page);
                List<string> bookIds = Favorite.getAllId().ToList();
                if (books.items != null && books.items.Count() > 0) 
                {
                    foreach (var book in books.items)
                    {
                        if (bookIds.Any<string>(bk => bk.Equals(book.id)))
                        {
                            book.Favorite = true;
                        }
                        UcCardBook card = new UcCardBook(book);
                        card.Name = "book" + book.id;
                            
                        fpnlBooks.Controls.Add(card);
                    }
                    pnlFundo.Refresh();
                }
                totalItems = books.totalItems;
                setStatusButtons();
                setButtonVisibility(true);
                changeStatusSearchPanel(false);
                statusButtonBuscar(true);
            }
        }

        private void statusButtonBuscar(bool enable) 
        {
            btnBuscar.Enabled = enable;
            btnBuscar.Refresh();
        }

        private void changeStatusSearchPanel(bool loading)
        {
            if (loading)
            {
                fpnlBooks.Controls.Clear();
            }
            pnlLoad.Visible = loading;
            pnlFundo.Visible = !loading;
            fpnlBooks.Visible = !loading;
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btnBuscar_Click(null, null);
            }
        }

        private void btnPreviewPage_Click(object sender, EventArgs e)
        {
            page--;
            btnBuscar_Click(null, null);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            page = 0;
            btnBuscar_Click(null, null);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            page++;
            btnBuscar_Click(null, null);
        }
    }
}
