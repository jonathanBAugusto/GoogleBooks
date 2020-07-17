using GoogleBooks.Connection;
using System.Collections.Generic;

namespace GoogleBooks.Model
{
    public class Book : Conn
    {
        public string id { get; set; }
        public string selfLink { get; set; }
        private bool favorite = false;
        public bool Favorite
        {
            get { return favorite; }
            set { favorite = value; }
        }

        public VolumeInfo volumeInfo { get; set; }

        public Book() { }

        public void setFavorite()
        {
            GoogleBooks.Model.Favorite.insert(new GoogleBooks.Model.Favorite(
                id: id,
                title: volumeInfo.title,
                description: volumeInfo.description,
                thumbnail: volumeInfo.imageLinks.thumbnail,
                smallThumbnail: volumeInfo.imageLinks.smallThumbnail
                )); 
            Favorite = true;
        }
        public void unsetFavorite()
        {
            GoogleBooks.Model.Favorite.delete(id);
            Favorite = false;
        }
    }

    class ItemsBook 
    {
        public IEnumerable<Book> items { get; set; }
        public int totalItems { get; set; }
    }


}
