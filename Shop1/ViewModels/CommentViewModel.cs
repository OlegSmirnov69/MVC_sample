using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Shop1.ViewModels
{
    public class CommentViewModel
    {
        
        [Display(Name = "Date")]
        public string Date { get; set; }

        
        [Display(Name = "Text")]
        public string Text { get; set; }

        
    }
}
