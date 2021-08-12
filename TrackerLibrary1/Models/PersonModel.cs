using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Id of person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// First name of person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// last name of person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// email address of person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// phone number of person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}