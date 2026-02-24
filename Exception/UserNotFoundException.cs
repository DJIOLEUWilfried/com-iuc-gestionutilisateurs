using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_iuc_gestionutilisateurs.Exception
{
    public class UserNotFoundException : IOException
    {
        /// <summary>
        /// 
        /// Exception levée lorsqu'un utilisateur n'est pas trouver.
        /// 
        /// </summary>
        /// <param name="message"></param>
        public UserNotFoundException(string message) : base(message) { }

    }


}
