using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace EventAPI.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
       // public List<Participant> Participants { get; set; }
    }
}
