using System;
using System.Windows.Forms;
using GoogleBooks.Model;

namespace GoogleBooks.View
{
    public partial class UcCardBook : UserControl
    {
        private Book book;
        public UcCardBook(Book book)
        {
            InitializeComponent();
            this.book = book;
        }
        public void changeFavorite(bool isFavorite) 
        {
            book.Favorite = isFavorite;
        }
        public void changeBtnImg() 
        {
            btnFavorite.Refresh();
            btnFavorite.BackgroundImage = book.Favorite ? GoogleBooks.Properties.Resources.star48px : GoogleBooks.Properties.Resources.void_star48px;
            btnFavorite.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void UcCardBook_Load(object sender, EventArgs e)
        {
            lblTitle.Text = book.volumeInfo.title;
            txtDescription.Text = book.volumeInfo.description;
            lblPublisher.Text = book.volumeInfo.publisher;
            if (string.IsNullOrEmpty(book.volumeInfo?.imageLinks?.thumbnail))
            {
                picBook.Image = GoogleBooks.Properties.Resources.no_image;
                picBook.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else 
            {
                picBook.LoadAsync(book.volumeInfo.imageLinks.thumbnail);
                picBook.SizeMode = PictureBoxSizeMode.Zoom;
            }

            changeBtnImg();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (!book.Favorite)
            {
                book.setFavorite();
                UcFavoritos.addToList(new Favorite(
                    id: book.id,
                    title: book.volumeInfo.title,
                    description: book.volumeInfo.title,
                    thumbnail: book.volumeInfo.imageLinks.thumbnail,
                    smallThumbnail: book.volumeInfo.imageLinks.smallThumbnail
                    ));
            }
            else
            {
                book.unsetFavorite();
                UcFavoritos.removeFromList(book.id);
            }
            changeBtnImg();
        }
    }
}
