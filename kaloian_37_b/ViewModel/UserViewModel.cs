using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kaloian_37_b.ViewModel
{
    internal class UserViewModel

    {
        private Model.User _user;

        public UserViewModel(Model.User user)
        {
            _user = user;
        }
        public string Name { get { return _user.Names; } set { _user.Names = value; } }
        public string Email { get { return _user.Email[0] + "*****@*****.***"; } set { _user.Names = value; } }

        public string IsAdmin { get { return _user.ISAdmin ? "ADMIN" : "No"; } }
        public string IsBlocked { get { return _user.ISBlocked ? "Yes" : "No"; } }

    }
}
