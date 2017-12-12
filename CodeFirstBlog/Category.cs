using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBlog
{
    public class Category : Entity  
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }


        //Mapping

        public virtual List<Article> Article { get; set; }
    }
}
