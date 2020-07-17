using System;
using System.Linq;
using System.Windows.Forms;
using GoogleBooks.Model;

namespace GoogleBooks.View
{
    public partial class UcCardFavorito : UserControl
    {
        private Favorite favorite;
        public UcCardFavorito(Favorite favorite)
        {
            InitializeComponent();
            this.favorite = favorite;
        }

        private void UcCardFavorito_Load(object sender, EventArgs e)
        {
            lblTitle.Text = favorite.title;
            txtDescription.Text = favorite.description;
            if (string.IsNullOrEmpty(favorite.thumbnail))
            {
                thumbBook.Image = GoogleBooks.Properties.Resources.no_image;
                thumbBook.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                thumbBook.LoadAsync(favorite.thumbnail);
                thumbBook.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            Favorite.delete(favorite.id);
            UcFavoritos.flowPanel.Controls.Remove(UcFavoritos.flowPanel.Controls.Find("card" + favorite.id, true).FirstOrDefault());
            UcFavoritos.flowPanel.Refresh();
            if (UcPesquisa.flowPanel != null) 
            {
                UcCardBook fav = (UcCardBook) UcPesquisa.flowPanel.Controls.Find("book" + favorite.id, false).FirstOrDefault();
                fav.changeFavorite(false);
                fav.changeBtnImg();
                fav.Refresh();
            }
        }
    }
}
