

using Library.Helper.Enums;
using TaskLibrary.Interfaces;

namespace TaskLibrary.Entities
{
    internal class User:IEntity
    {
       
        public  string UserName   { get; set; }
        public  string  Email  { get; set; }
        public Roles Role { get; set; }
        public Guid Id { get ; set; }

        public User(string userName, string email, Roles role)
        {
            UserName = userName;
            Email = email;
            Role = role;
        }

        public override string ToString()
        {
            return $"Username:{UserName}, Email:{Email}, Role {Role}";
        }
    }
}
