using Dal_Repository.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.modelsConverters
{
    internal class CustomerConvert
    {
        public  CustomerConvert()
        {

        }
        public static Dto_Common_Enteties.CustomerDto TocustomertDto(models.Customer cr)
        {

            Dto_Common_Enteties.CustomerDto c = new Dto_Common_Enteties.CustomerDto();
            c.CustomerId = cr.CustomerId;   
            c.CustomerName = cr.CustomerName;   
            c.BirthDate = cr.BirthDate;
            c.Phone = cr.Phone; 
            c.Email = cr.Email;
            return c;   

        }
        public static List<Dto_Common_Enteties.CustomerDto> TocustomertDtoList(List<models.Customer> crl)
        {
           List< Dto_Common_Enteties.CustomerDto> c = new List< Dto_Common_Enteties.CustomerDto>();
            foreach (var customer in crl)
            {
                c.Add(TocustomertDto(customer));
            }
            return c;

            }
        public static models.Customer ToCustomer(Dto_Common_Enteties.CustomerDto ca)
        {
            models.Customer a = new models.Customer();
            a.CustomerId = ca.CustomerId;
            a.CustomerName = ca.CustomerName;   
            a.BirthDate = ca.BirthDate; 
            a.Phone = ca.Phone;     
            a.Email = ca.Email; 

            return a;
        }
    }
}