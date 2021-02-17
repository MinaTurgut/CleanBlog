using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanBlog.Entity
{
    public class Post
    {

        public int PostID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime WritePost { get; set; } = DateTime.Now;
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
    }
}
