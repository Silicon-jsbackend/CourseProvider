using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProvider.Infrastructure.Models;

public class Course
{
    public string Id { get; set; }
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal DiscountPrice { get; set; }
    public decimal Hours { get; set; }
    public bool IsBestseller { get; set; }
    public decimal LikesInNumbers { get; set; }
    public decimal LikesInProcent { get; set; }
    public string? Author { get; set; }
    public string? ImageName { get; set; }

    public string? CategoryId { get; set; }
    public virtual CategoryModel? Category { get; set; }

    public class CategoryModel
    {
        public string Id { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}

