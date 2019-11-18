using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestProfilerWithCore3.ModelEF;

namespace TestProfilerWithCore3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSQLConnect_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=efprof_core;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                String query = "select * from Blogs";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dataReader;

                try
                {
                    connection.Open();
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader.GetValue(0)} - {dataReader.GetValue(1)} - {dataReader.GetValue(2)}");
                    }
                    dataReader.Close();
                    command.Dispose();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection!");
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        
        private void EFbuttonAdd_Click(object sender, EventArgs e)
        {
            // Add new Blog entry to Blogs table
            try
            {
                using var dbContext = new myContext();
                var newBlog = new Blog()
                {
                    Title = "from EF",
                    CreatedAt = DateTime.Now,
                    Subtitle = "SubFromEF"
                    // Note : There is an issue with EF with this subtitle field
                    //        Although this field IS marked as 'allow nulls' in the sql server, the EF doesn't work if it is null
                    //        It is NOT a profiler issue, it is some issue with the EF core
                    //        See: https://stackoverflow.com/a/55889874/5737562
                };

                dbContext.Blogs.Add(newBlog);
                dbContext.SaveChanges();
                var lastBlogId = newBlog.Id;
                Console.WriteLine($"Added Blog: Blog with id {lastBlogId} was added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void EFbuttonGetAllBlogs_Click(object sender, EventArgs e)
        {
            // Get all blogs from Blogs table
            try
            {
                using var dbContext = new myContext();
                var blogs = dbContext.Blogs.OrderByDescending(b => b.Id).ToList();
                // Note: This will Not work if there are NULLs in the subtitle field in any entry in the table, see above note. 
             
                foreach (var blog in blogs)
                {
                    Console.WriteLine($"Blog Entry: Blog Id={blog.Id} Title={blog.Title} Created At={blog.CreatedAt}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        private void EFbuttonGetById_Click(object sender, EventArgs e)
        {
            // Get blog from Blogs table by ID
            try
            {
                if (int.TryParse(TextBoxBlogId.Text, out int id))
                {
                    using var dbContext = new myContext();
                    var blog = dbContext.Blogs.First<Blog>(b => b.Id == id);
                    Console.WriteLine($"Get Blog by ID: Blog Id={id} Title={blog.Title}, Created at={blog.CreatedAt}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void EFbuttonUpdate_Click(object sender, EventArgs e)
        {
            // Update blog entry to now
            try
            {
                if (int.TryParse(TextBoxBlogId.Text, out int id))
                {
                    using var dbContext = new myContext();
                    var blog = dbContext.Blogs.First<Blog>(b => b.Id == id);
                    blog.CreatedAt = DateTime.Now;
                    dbContext.SaveChanges();
                    Console.WriteLine($"Updated 'Created At' for blog {id} to now");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void EFbuttonDelete_Click(object sender, EventArgs e)
        {
            // Delete a blog entry
            try
            {
                if (int.TryParse(TextBoxBlogId.Text, out int id))
                {
                    using var dbContext = new myContext();
                    var blog = dbContext.Blogs.First<Blog>(b => b.Id == id);
                    dbContext.Remove(blog);
                    dbContext.SaveChanges();
                    Console.WriteLine($"Deleted blog with id={id}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void EFGetBlogFromPost_Click(object sender, EventArgs e)
        {
            // Get blog from a post (related document)
            try
            {
                if (int.TryParse(TextBoxBlogId.Text, out int postId))
                {
                    using var dbContext = new myContext();
                    var post = dbContext.Posts.Where<Post>(p => p.Id == postId)
                        .Include(p => p.Blog)
                        .ToList();
                    var blog = post[0].Blog;
                    Console.WriteLine($"Blog from Post: *** Blog Id={blog.Id} Title={blog.Title}, Created at={blog.CreatedAt}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void EFbuttonGetBlogsCount_Click(object sender, EventArgs e)
        {
            // Get blogs count using a Raw Query
            try
            {
                using var dbContext = new myContext();
                IList<Blog> blogs = dbContext.Blogs.FromSqlRaw("SELECT * FROM dbo.Blogs").ToList();
                Console.WriteLine("blogs.Count = " + blogs.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void EFbuttonAnyQuery_Click(object sender, EventArgs e)
        {
            // Any raw Query (on Blogs)
            var queryFromUI = QueryTextBox.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(queryFromUI) == false)
                {
                    using var dbContext = new myContext();
                    IList<Blog> blogs = dbContext.Blogs.FromSqlRaw(queryFromUI).ToList();
                    Console.WriteLine($"Executed query: {queryFromUI}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
