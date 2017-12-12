using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBlog
{
   public class Article : Entity
    {
        public Article()
        {
            ModifiedDate = DateTime.Now;
        }

        public int ArticleId { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string Body { get; set; }

        public string Title { get; set; }

        public int CategoryId { get; set; }

        //Mapping

        public virtual List<Comment> Comments { get; set; }

        public virtual Category Category { get; set; }
    }
}
