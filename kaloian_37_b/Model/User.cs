using kaloian_37_b.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

    public class User
    {
        private string _names = string.Empty;
        private string _password = string.Empty;
        private string _email = string.Empty;
        private string _facNum = string.Empty;
        private UserRolesEnum _role;
        private int _FailedLA = 0;

        public string Names { get { return _names; } set { _names = value;  } }
        public UserRolesEnum Role
        {
            get { return _role; }
            set { _role = value; }
        }
        public string FacultityNumber { get { return _facNum; } set { _facNum = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password
        {
            get { return Decript(_password); }   
            set { _password = Encript(value); } 
        }
        public int FailedLoginAttempts { get { return _FailedLA; } set { _FailedLA = value; } }

        public bool ISAdmin
        {
            get { return Role == UserRolesEnum.ADMIN; }
        }

        public bool ISBlocked
        {
            get { return FailedLoginAttempts > 5; }
        }

        public string Encript(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public string Decript(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // reverse пак връща оригинала
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public User(string names, string password, string email, UserRolesEnum role, string fNum)
        {
            this.Names = names ?? string.Empty;
            this.Password = password ;
            this.Email = email ?? string.Empty;
            this.Role = role;
            this.FacultityNumber = fNum ?? string.Empty;
            this.FailedLoginAttempts = 0;
        }



    }

}
