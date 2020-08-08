using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace dojo_survey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Your Name")]
        public string Name {get;set;}

        [Required]
        [Display(Name = "Dojo Location")]
        public string Location {get;set;}

        [Required]
        [Display(Name = "Favorite Language")]
        public string Language {get;set;}

        [MinLength(20)]
        public string Comment {get;set;}

        public List<SelectListItem> Locations {get;} = new List<SelectListItem>()
        {
            new SelectListItem { Value = "SJ", Text = "San Jose" },
            new SelectListItem { Value = "SA", Text = "Seattle" },
            new SelectListItem { Value = "MC", Text = "McLean" },
            new SelectListItem { Value = "BE", Text = "Boise" },
        };
        public List<SelectListItem> Languages {get;} = new List<SelectListItem>()
        {
            new SelectListItem { Value = "C", Text = "C#" },
            new SelectListItem { Value = "J", Text = "Java" },
            new SelectListItem { Value = "PY", Text = "Python" },
            new SelectListItem { Value = "R", Text = "Ruby" },
        };
    }
}