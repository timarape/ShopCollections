﻿using PieShop.Core.Models;
using System.Collections.Generic;

namespace PieShop.Data.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
