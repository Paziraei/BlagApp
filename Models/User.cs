namespace Models.Base
{
    public class User :BaseEntity
    {
        public User()
        {
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NatiralCode { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<TypeWork> TypeWorks { get; set; }

    }
}
