using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AM.ApplicationCore.Domain
{
    // [Owned]  methode1
    public class FullName
    {
        [MinLength(3, ErrorMessage = "min 3"), MaxLength(25, ErrorMessage = "max 25")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
