﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProvider.Infrastructure.Data.Entities;

public class CourseEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal DiscountPrice { get; set; }
    public int Hours { get; set; }
    public bool IsBestseller { get; set; }
    public decimal LikesInNumbers { get; set; }
    public decimal LikesInProcent { get; set; }
    public string? Author { get; set; }
    public string? ImageName { get; set; }

    public int? CategoryId { get; set; }
    public virtual CategoryEntity? Category { get; set; }
}
