using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OC.Data.Models
{
    public enum ECategory
    {
        [Display(Name = "Java Spring")]
        Java,
        [Display(Name = "ASP.NET Core")]
        Sharp,
        [Display(Name = "JavaScript")]
        Javascript,
        [Display(Name = "Ruby on Rails")]
        Ruby,
        [Display(Name = "Python Django")]
        Python
    }

    public class Manual
    {
        [Key]
        public int ManualId { get; set; }
        public string AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public ECategory Category { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime LastUpdate { get; set; }
    }
}
