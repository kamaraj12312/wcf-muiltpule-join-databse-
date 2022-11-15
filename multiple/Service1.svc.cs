using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace multiple
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        
        //public List<Book> GetProducts()
        //{
            //var tamil = (from s in text.Products
            //             join d in entities.Books on s.ProductID equals d.Id

            //             select s).AsEnumerable().Select(x => new Products

            //             {
            //                 ProductID = x.ProductID,
            //                 ProductName = x.ProductName,
            //                 ProductOwner = x.ProductOwner,


            //             }).ToList();
















            //var Test = new TestDBContext();
            //var sample = new SampleProductContext();

            //var users = Test.UserApi.ToList();
            //var sectors = sample.Book.ToList();

            //var task = ((from UserApi in users
            //             join sector in sectors on UserApi.Id equals sector.Id

            //             select sector).AsEnumerable().Select(x => new Book()
            //             {
            //                 Id = x.Id,
            //                 Isbn = x.Isbn,
            //                 Author = x.Author
            //             }
            //            ).ToList());

            //return task;





            //var db1 = new TestDBEntities();
            //var db2 = new SampleProductEntities();

            //var users = db1.Books.ToList();
            //var sectors = db2.Products.ToList();




            //var task = ((from Book in users
            //             join sector in sectors on Book.Id equals sector.ProductID

            //             select sector).AsEnumerable().Select(x => new Book()
            //             {
            //                Id =x.ProductID,
            //                Title =x.ProductName
            //             }
            //            ).ToList());

            //return task;
















            //var tamil = (from s in text.Products
            //             join d in entities.Books on s.ProductID equals d.Id

            //             select s).AsEnumerable().Select(x => new Products

            //             {
            //                 ProductID = x.ProductID,
            //                 ProductName = x.ProductName,
            //                 ProductOwner = x.ProductOwner,


            //             }).ToList();


            //var tables =(from a in text.Products




            //             )











            //var tamil = from s in text.Products
            //            join d in entities.Books on s.ProductID equals d.Id

            //            select new
            //            {
            //                ProductID = s.ProductID,
            //                ProductName = s.ProductName,
            //                ProductOwner = s.ProductOwner,
            //                ID = d.Id,
            //                title =d.Title
            //            };
            ////return tamil;
      //  }

        List<Products> IService1.GetProducts()
        {

            var db1 = new TestDBEntities();
            var db2 = new SampleProductEntities();

            var users = db1.Books.ToList();
            var sectors = db2.Products.ToList();




            var task = ((from Book in users
                         join sector in sectors on Book.Id equals sector.ProductID
                         

                         select sector).AsEnumerable().Select(x => new Products()
                         {
                             Id =x.ProductID,
                              title =x.ProductName
                         }
                        ).ToList());

            return task;
        }
    }
}
