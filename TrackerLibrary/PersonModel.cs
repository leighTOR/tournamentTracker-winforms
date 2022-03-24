using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of a player.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the last name of a player.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email address that will be
        /// use to send updates and reminders for players.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the Cellphone number that will be
        /// use as alternative to email address in sending
        /// updates and reminders to players.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}