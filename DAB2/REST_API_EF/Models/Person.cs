using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace REST_API_EF.Models
{
    public class Person
    {

            public int PersonID { get; set; }
            [Required]
            public Email Email { get; set; }
            public string FamilyName { get; set; }
            public string Type { get; set; }
            public string GivenName { get; set; }
            public string MiddleName { get; set; }

    }
}