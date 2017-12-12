using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstBlog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonelBlogEntities pr = new PersonelBlogEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            var result = pr.Categories.ToList();
            dataGridView1.DataSource = result;
        }
        
        //makale ekle
        private void button1_Click(object sender, EventArgs e)
        {
            Article mak = new Article
            {
                ArticleId = 1,
                CategoryId=1,
                Title = textBox1.Text,
                Body = textBox2.Text
            };
            pr.Articles.Add(mak);
            pr.SaveChanges();
        }
        //kullanıcı ekle
        private void button2_Click(object sender, EventArgs e)
        {
            User us = new User {
                Name = textBox3.Text
            };
            pr.Users.Add(us);
            pr.SaveChanges();
        }
        //kategori ekle
        private void button3_Click(object sender, EventArgs e)
        {
            Category cat = new Category {
                CategoryId= 1,
                CategoryName = textBox4.Text,
                Description = textBox5.Text
            };
            pr.Categories.Add(cat);
            pr.SaveChanges();
        }
    }
}
