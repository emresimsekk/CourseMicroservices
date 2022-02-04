﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Models.Catalogs
{
    public class CourseViewModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
        public string StockPictureUrl { get; set; }
        public DateTime CreateTime { get; set; }
        public int Minute { get =>  Convert.ToInt32((DateTime.Now-CreateTime).Minutes); }
        public string Description { get; set; }
        public string ShortDescription { get => Description.Length > 100 ? Description.Substring(0, 100) + ".." : Description; }
        public FeatureViewModel Feature { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}