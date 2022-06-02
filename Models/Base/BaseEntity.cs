namespace Models.Base;

public abstract class BaseEntity
{
    public BaseEntity()
    {
    }
    public string Discription { get; set; }
    public int  Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DateCreate { get; set; }
}
