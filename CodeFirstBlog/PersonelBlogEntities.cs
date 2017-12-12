using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBlog
{
    public class PersonelBlogEntities:DbContext
    {
        public PersonelBlogEntities() :base
            ("name=BlogCon")
        {

                
        }
        public DbSet<Article> Articles { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<PersonelBlogEntities>(new DropCreateDatabaseIfModelChanges<PersonelBlogEntities>());
            modelBuilder.Entity<Category>().Property(c => c.CategoryName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Id).IsRequired();
        }

    }
}
