using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanBlog.Models
{
    public class HomePostDetail
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime WritePost { get; set; } = DateTime.Now;
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }


    }
}
