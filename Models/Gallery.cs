namespace Models.Base
{
    public class Gallery : BaseEntity
    {
        public Gallery()
        {
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}
