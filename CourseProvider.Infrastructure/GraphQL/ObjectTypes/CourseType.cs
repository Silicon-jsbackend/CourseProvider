using CourseProvider.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProvider.Infrastructure.GraphQL.ObjectTypes;

public class CourseType : ObjectType<CourseEntity>
{
    protected override void Configure(IObjectTypeDescriptor<CourseEntity> descriptor)
    {
        descriptor.Field(x => x.Id).Type<NonNullType<IdType>>();
        descriptor.Field(x => x.Title).Type<NonNullType<StringType>>();
        descriptor.Field(x => x.Price).Type<NonNullType<DecimalType>>();
        descriptor.Field(x => x.DiscountPrice).Type<NonNullType<DecimalType>>();
        descriptor.Field(x => x.Hours).Type<NonNullType<IntType>>();
        descriptor.Field(x => x.IsBestseller).Type<NonNullType<BooleanType>>();
        descriptor.Field(x => x.LikesInNumbers).Type<NonNullType<DecimalType>>();
        descriptor.Field(x => x.LikesInProcent).Type<NonNullType<DecimalType>>();
        descriptor.Field(x => x.Author).Type<StringType>();
        descriptor.Field(x => x.ImageName).Type<StringType>();
    }

    public class CategoryType : ObjectType<CategoryEntity>
    {
        protected override void Configure(IObjectTypeDescriptor<CategoryEntity> descriptor)
        {
            descriptor.Field(x => x.Id).Type<NonNullType<IdType>>();
            descriptor.Field(x => x.CategoryName).Type<NonNullType<StringType>>();
        }
    }
}
