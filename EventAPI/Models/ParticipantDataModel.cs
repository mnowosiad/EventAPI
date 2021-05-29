using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventAPI.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

       // [ForeignKey("EventId")]
        public int EventId { get; set; }
       // public Event Event { get; set; }
    }
}
