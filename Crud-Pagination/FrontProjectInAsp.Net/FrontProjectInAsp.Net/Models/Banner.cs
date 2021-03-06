using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontProjectInAsp.Net.Models
{
    public class Banner
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Discount { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
