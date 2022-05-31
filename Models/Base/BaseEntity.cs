

namespace Models.Base
{
    public class BaseEntity
    {
        public BaseEntity()
        {
        }
        public string Discription { get; set; }
        public int  Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
