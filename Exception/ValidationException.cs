using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_iuc_gestionutilisateurs.Exception
{
    public class ValidationException : IOException
    {

        /// <summary>
        /// 
        /// Exception levée lorsqu'une donnée recupée à vue est invalide.
        /// 
        /// </summary>
        /// <param name="message"></param>
        public ValidationException(string message) : base(message) { }


    }

}
