using Microsoft.EntityFrameworkCore;

namespace TestProfilerWithCore3.ModelEF
{
    
    
    // TODO: Change to BlogContext
    public class myContext : DbContext
    {
        private readonly string connectionString;

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }

//        public myContext(string connectionString)
        public myContext()
        {
            //this.connectionString = connectionString;
            this.connectionString = "server=.\\sqlexpress;database=efprof_core;trusted_connection=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}