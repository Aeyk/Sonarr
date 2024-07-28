using System;
using NzbDrone.Core.Datastore;

namespace NzbDrone.Core.Authentication
{
    public enum Role
    {
        User = 0,
        Admin = 1,
    }

    public class User : ModelBase
    {
        public User()
        {
            RoleId = (int)Role.User;
        }

        public Guid Identifier { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public int Iterations { get; set; }
        public int RoleId { get; set; }
    }
}
