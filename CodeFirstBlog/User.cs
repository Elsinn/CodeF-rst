using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBlog
{
   public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }//guid 32 bitlik kendi içeriinde uniq bir ıd olusturur.

        public string Name { get; set; }

        //Mapping

        public virtual List<Comment>Comments { get; set; }
    }
}
