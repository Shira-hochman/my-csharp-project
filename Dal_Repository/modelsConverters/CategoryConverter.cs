using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.modelsConverters
{
    public class CategoryConverter
    {
        public CategoryConverter() 
        { 
        }

        public static Dto_Common_Enteties.CategoryDto ToCategoryDto(models.Category ca) { 
            Dto_Common_Enteties.CategoryDto c = new Dto_Common_Enteties.CategoryDto();
            c.CategoryId = ca.CategoryId;    
            c.CategoryName = ca.CategoryName;   
            return c;
          
    }
        public static List<Dto_Common_Enteties.CategoryDto> ToCategorytDtoList(List<models.Category> cal)
        {
            List<Dto_Common_Enteties.CategoryDto> l = new List<Dto_Common_Enteties.CategoryDto>();
            foreach (var category in cal)
            {
                l.Add(ToCategoryDto(category));
            }
            return l;
        }
    }
}
