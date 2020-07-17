using System.Collections.Generic;

namespace GoogleBooks.Model
{
    public class VolumeInfo
    {
        public string title { get; set; }
        public IEnumerable<string> authors { get; set; }
        public string publisher { get; set; }
        public string description { get; set; }
        public ImageLinks imageLinks { get; set; }
        public VolumeInfo() { }
    }
}
