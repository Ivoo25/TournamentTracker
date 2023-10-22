using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Mdels
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of the person.
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Represents the last name of the person.
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Represents the email address of the person.
        /// </summary>
        public string emailAddress { get; set; }

        /// <summary>
        /// Represents the cellphone number of the person.
        /// </summary>
        public string cellphoneNumber { get; set; }
    }
}
