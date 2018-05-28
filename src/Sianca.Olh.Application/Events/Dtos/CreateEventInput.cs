using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sianca.Olh.Events.Dtos
{
    public class CreateEventInput
    {
        [Required]
        [StringLength(Event.MaxTitleLength)]
        public string Title { get; set; }

        [StringLength(Event.MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        [Range(0, int.MaxValue)]
        public int MaxRegistrationCount { get; set; }
    }
}
