using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBlog
{
   public class Comment : Entity
    {
        public Comment()
        {
            IsApproved = false;
        }
        public int CommentId { get; set; }

        public bool IsApproved { get; set; }

        public string Title { get; set; }

        public string CommentBody { get; set; }

        public Guid UserId { get; set; }

        public int ArticleId { get; set; }

        //Mapping

        public virtual User User { get; set; }

        public virtual Article Article { get; set; }
    }
}
