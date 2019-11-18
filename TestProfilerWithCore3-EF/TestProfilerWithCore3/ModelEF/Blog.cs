using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProfilerWithCore3.ModelEF
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Post> Posts { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        [Column(Order = 3)]
        public bool AllowsComments { get; set; }
        public string Subtitle { get; set; }
        public ICollection<User> Users { get; set; }
    }
}