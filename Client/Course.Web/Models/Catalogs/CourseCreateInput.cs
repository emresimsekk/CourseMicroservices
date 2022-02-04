using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Models.Catalogs
{
    public class CourseCreateInput
    {   
        public string UserId { get; set; }
        [Display(Name = "Kurs Kategori")]
       
        public string CategoryId { get; set; }
        [Display(Name = "Kurs İsmi")]
       
        public string Name { get; set; }
        public string Picture { get; set; }
        [Display(Name = "Kurs Fiyatı")]
        
        public decimal Price { get; set; }
        [Display(Name = "Kurs Açıklama")]
       
        public string Description { get; set; }
        public FeatureViewModel Feature { get; set; }
        [Display(Name = "Kurs Resmi")]
        public IFormFile PhotoFormFile { get; set; }
    }
}
