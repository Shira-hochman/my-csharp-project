using Dal_Repository.models;
using Dto_Common_Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.modelsConverters
{
    internal class ProductConverter
    {
        public ProductConverter()
        {

        }
        public static Dto_Common_Enteties.ProductDto ToproductDto(models.Product pr)
        {
            Dto_Common_Enteties.ProductDto p = new Dto_Common_Enteties.ProductDto();
            p.ProductId = pr.ProductId;
            p.ProductName = pr.ProductName;
            p.CategoryId = pr.CategoryId;
            p.CompanyId = pr.CompanyId;
            p.Description = pr.Description;
            p.Image = pr.Image;
            p.Price = pr.Price;
            p.LastUpdated = pr.LastUpdated;
            p.Age= pr.Age;  
            
            return p;
        }
        public static List<Dto_Common_Enteties.ProductDto> ToProductDtoList(List<models.Product> lpr)
        {
            List<Dto_Common_Enteties.ProductDto> l = new List<Dto_Common_Enteties.ProductDto>();
            foreach (var product in lpr)
            {
                l.Add(ToproductDto(product));
            }
            return l;
        }
        public static models.Product Toproduct(models.Product pr)
        {
            models.Product p = new models.Product();
            p.ProductId = pr.ProductId; 
            p.ProductName = pr.ProductName;
            p.CategoryId = pr.CategoryId;
            p.CompanyId = pr.CompanyId;
            p.Description = pr.Description;
            p.Image = pr.Image;
            p.Price = pr.Price;
            p.LastUpdated = pr.LastUpdated;
            p.Age = pr.Age;
            p.Category.CategoryName = pr.Category.CategoryName;
            return p;


        }
        public static List<ProductDto> ToproductDto(List<models.Product> products)
        {
            

            return products.Select(pr => new ProductDto
            {
                ProductId = pr.ProductId,
                ProductName = pr.ProductName,
                CategoryId = pr.CategoryId,
                CompanyId = pr.CompanyId,
                Description = pr.Description,
                Image = pr.Image,
                Price = pr.Price,
                LastUpdated = pr.LastUpdated,
                Age = pr.Age,
                CategoryName = pr.Category?.CategoryName // אם הקטגוריה יכולה להיות null
            }).ToList();
        }


    }
}