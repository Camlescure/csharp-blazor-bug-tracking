using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MinLength(10, ErrorMessage="The minimum length for description is 10 caracters.")]
        public string Description { get; set; }

        [Required]
        [Range(1,5, ErrorMessage="The priorit must be between 1 and 5.")]
        public int Priority { get; set; }
    }
}
