﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Models.ViewModels
{
    public class CategoryVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
