using System;
using System.Collections.Generic;

namespace TestProfilerWithCore3.ModelEF
{
    public class Post
    {
        public int Id { get; set; }

        public Blog Blog { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PostedAt { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}