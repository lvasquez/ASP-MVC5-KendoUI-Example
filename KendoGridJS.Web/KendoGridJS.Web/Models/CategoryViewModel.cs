﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoGridJS.Web.Models
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}