using Products.Models;

namespace Products.API.Data
{
    public static class ProductsDataContextExtensions
    {
        public static void SeedData(this ProductsDataContext context)
        {
            context.Categories.AddRange
                (
                    new Category
                    {
                        Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                        CategoryName = "Sport",
                        Active = true,
                        CreatedDate = DateTime.Now.AddDays(-13),
                        LastModifiedDate = DateTime.Now.AddDays(-3),
                    },
                    new Category
                    {
                        Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c201"),
                        CategoryName = "Food",
                        Active = true,
                        CreatedDate = DateTime.Now.AddDays(-11),
                        LastModifiedDate = DateTime.Now.AddDays(-5),
                    }, new Category
                    {
                        Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c202"),
                        CategoryName = "Furniture",
                        Active = true,
                        CreatedDate = DateTime.Now.AddDays(-18),
                        LastModifiedDate = DateTime.Now.AddDays(-4),
                    }


                );
            context.Products.AddRange
                (
                    new Product
                    {
                        Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c203"),
                         Description= "mountain bicycle",
                         ProductName="bicycle",
                         CategoryId= new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                         Active = true,
                         ProductCode="SRPR3",
                         CreatedDate = DateTime.Now.AddDays(-18),
                         LastModifiedDate = DateTime.Now.AddDays(-4)
                    }, new Product
                    {
                        Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c204"),
                        Description = "sport shoes for running",
                        ProductName = "sport shoes",
                        CategoryId = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                        Active = true,
                        ProductCode = "SRPR34",
                        CreatedDate = DateTime.Now.AddDays(-18),
                        LastModifiedDate = DateTime.Now.AddDays(-8)
                    }, new Product
                    {
                        Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c282"),
                        Description = "sport shirts for hiking",
                        ProductName = "sport shirts",
                        CategoryId = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                        Active = true,
                        ProductCode = "SRPR35",
                        CreatedDate = DateTime.Now.AddDays(-18),
                        LastModifiedDate = DateTime.Now.AddDays(-7)
                    }, new Product
                    {
                        Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c205"),
                        Description = "eco milk",
                        ProductName = "milk",
                        CategoryId = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c201"),
                        Active = true,
                        ProductCode = "FFD35",
                        CreatedDate = DateTime.Now.AddDays(-18),
                        LastModifiedDate = DateTime.Now.AddDays(-17)
                    }, new Product
                    {
                        Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c206"),
                        Description = "cottage cheese",
                        ProductName = "cheese",
                        CategoryId = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c201"),
                        Active = true,
                        ProductCode = "FFD39",
                        CreatedDate = DateTime.Now.AddDays(-18),
                        LastModifiedDate = DateTime.Now.AddDays(-17)
                    }, new Product
                    {
                        Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c207"),
                        Description = "modern style",
                        ProductName = "table",
                        CategoryId = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c202"),
                        Active = true,
                        ProductCode = "FFD54",
                        CreatedDate = DateTime.Now.AddDays(-18),
                        LastModifiedDate = DateTime.Now.AddDays(-12)
                    }, new Product
                    {
                        Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c208"),
                        Description = "fine old style",
                        ProductName = "chair",
                        CategoryId = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c202"),
                        Active = true,
                        ProductCode = "FFD40",
                        CreatedDate = DateTime.Now.AddDays(-18),
                        LastModifiedDate = DateTime.Now.AddDays(-12)
                    }

                );

            context.SaveChanges();
        }
    }
}
