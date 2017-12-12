using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBlog
{
   public class Entity
    {
        public Entity()
        {
            CreateDate = DateTime.Now;
        }
        public DateTime CreateDate { get; set; }

        public int Id { get; set; }

    }
}
