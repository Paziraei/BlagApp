namespace Models.Base
{
    public class Role :BaseEntity
    {
        public Role()
        {
        }
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; } 

    }
}
