using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace Mission11_Humphrey.Models
{
    public class Bookstore
    {
        [Key]
        [Required]
        public int  BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string PageCount { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
