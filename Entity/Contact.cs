using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanBlog.Entity
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactMail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMessage { get; set; }
    }
}
