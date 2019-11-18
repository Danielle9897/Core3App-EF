namespace TestProfilerWithCore3.ModelEF
{
    public class Comment
    {
        public int Id { get; set; }
        public Post Post { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public int Ip { get; set; }
        public string Text { get; set; }
    }
}