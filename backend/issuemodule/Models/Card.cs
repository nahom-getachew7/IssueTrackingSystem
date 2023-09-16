﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace issuemodule.Models
{
    public class Card
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        [NotMapped]
        [Display(Name = "File")]
          
        public IFormFile File { get; set; }
        public int StatePriority { get; set; }
       
    }
}
