using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class User :Base.BaseEntity
    {
        public User()
        {
        }

        [MaxLength(500)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string LastName { get; set; }

        [MaxLength(10)]
        public string NatiralCode { get; set; }

        [MaxLength(13)]
        public string Phone { get; set; }

        [MaxLength(200)]
        public string UserName { get; set; }

        [MaxLength(200)]
        public string Password { get; set; }

        public List<UserRole> UserRoles { get; set; }

        public List<Post> Posts { get; set; }

        public List<Comment> Comments { get; set; }
        public List<TypeWork> TypeWorks { get; set; }
    }
}
