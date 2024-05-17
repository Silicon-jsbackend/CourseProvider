using CourseProvider.Infrastructure.Data.Entities;
using CourseProvider.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProvider.Infrastructure.Factories;

public static class CourseFactory
{
    public static CourseEntity Create(CourseCreateRequest request)
    {
        return new CourseEntity
        {
            Title = request.Title,
            Price = request.Price,
            DiscountPrice = request.DiscountPrice,
            Hours = request.Hours,
            IsBestseller = request.IsBestseller,
            LikesInNumbers = request.LikesInNumbers,
            LikesInProcent = request.LikesInProcent,
            Author = request.Author,
            ImageName = request.ImageName,
            CategoryId = request.CategoryId,
            Category = request.Category != null ? new CategoryEntity
            {
                Id = request.Category.Id,
                CategoryName = request.Category.CategoryName
            } : null
        };
    }

    public static CourseEntity Create(CourseUpdateRequest request)
    {
        return new CourseEntity
        {
            Id = request.Id,
            Title = request.Title,
            Price = request.Price,
            DiscountPrice = request.DiscountPrice,
            Hours = request.Hours,
            IsBestseller = request.IsBestseller,
            LikesInNumbers = request.LikesInNumbers,
            LikesInProcent = request.LikesInProcent,
            Author = request.Author,
            ImageName = request.ImageName,
            CategoryId = request.CategoryId,
            Category = request.Category != null ? new CategoryEntity
            {
                Id = request.Category.Id,
                CategoryName = request.Category.CategoryName
            } : null
        };
    }

    public static Course Create(CourseEntity entity)
    {
        return new Course
        {
            Id = entity.Id,
            Title = entity.Title,
            Price = entity.Price,
            DiscountPrice = entity.DiscountPrice,
            Hours = entity.Hours,
            IsBestseller = entity.IsBestseller,
            LikesInNumbers = entity.LikesInNumbers,
            LikesInProcent = entity.LikesInProcent,
            Author = entity.Author,
            ImageName = entity.ImageName,
            CategoryId = entity.CategoryId,
            Category = entity.Category != null ? new Course.CategoryModel
            {
                Id = entity.Category.Id,
                CategoryName = entity.Category.CategoryName
            } : null
        };
    }
}
