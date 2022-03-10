using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;


namespace HH.dal.Models.User
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SecondName { get; set; }

        public DateTime? DateBirthday { get; set; }

        /// <summary>
        /// Наименование файла
        /// </summary>
        public string Photo { get; set; }

        public int? OrganizationId { get; set; }
    }
}
