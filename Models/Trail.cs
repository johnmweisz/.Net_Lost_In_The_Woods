using System.ComponentModel.DataAnnotations;
using System;
namespace LostInTheWoods.Models
{
    public class Trail
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MinLength(3)]
        [Display(Name = "Trail Name:")]
        public string Name { get; set; }
        [Required]
        [MinLength(10)]
        [Display(Name = "Description:")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Length in Miles:")]
        public int Length { get; set; }
        [Required]
        [Display(Name = "Change in Elevation:")]
        public int Elevation { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
    }
}