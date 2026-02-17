using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaloian_37_b.Model
{
    /*
    Pseudocode / Plan:
    - Fix the class declaration syntax (remove the stray parentheses).
    - Ensure non-nullable string fields are initialized to avoid CS8618:
        - Initialize _names, _password, _email, _role to empty strings.
    - Keep the existing constructor and have it assign properties (which set the backing fields).
    - Keep behavior for ISAdmin and ISBlocked unchanged.
    - Keep property names and accessors as in original code.
    */

    internal class User
    {
        private string _names = string.Empty;
        private string _password = string.Empty;
        private string _email = string.Empty;
        private string _role = string.Empty;
        private int _FailedLA = 0;

        public string Names { get { return _names; } set { _names = value;  } }
        public string Role { get { return _role; } set { _role = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public int FailedLoginAttempts { get { return _FailedLA; } set { _FailedLA = value; } }

        public bool ISAdmin
        {
            get { return Role.ToUpper() == "ADMIN"; }
        }

        public bool ISBlocked
        {
            get { return FailedLoginAttempts > 5; }
        }

        public User(string names, string password, string email, string role)
        {
            this.Names = names ?? string.Empty;
            this.Password = password ?? string.Empty;
            this.Email = email ?? string.Empty;
            this.Role = role ?? string.Empty;
            this.FailedLoginAttempts = 0;
        }
    }

}
