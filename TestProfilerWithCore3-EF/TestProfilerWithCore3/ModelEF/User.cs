using System;

namespace TestProfilerWithCore3.ModelEF
{
    public class User
    {
        public int Id { get; set; }
        public byte[] Password { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Bio { get; set; }
    }
}