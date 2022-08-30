using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Technologique_SVC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        TechnologiqueLinq1DataContext tc = new TechnologiqueLinq1DataContext();
        public int userLogin(string userEmail, string password)
        {
           var sysUser = (from u in tc.Users
                          where u.U_Email.Equals(userEmail) && u.U_Password.Equals(password).Equals(password)
                          select u).FirstOrDefault();

            if (sysUser != null)
            {
                return sysUser.User_Id;
            }
            else
            {
                return 0;
            }
        }

        public bool userRegister(string userName, string userSurname, string userEmail, string password)
        {
            var newUser = new User
            {
                U_Name = userName,
                U_Surname = userSurname,
                U_Email = userEmail,
                U_Password = password
            };
            tc.Users.InsertOnSubmit(newUser); 
            try
            {
                tc.SubmitChanges();
                return true;
            }
            catch(Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }
        public bool addProduct(string prodName, string prodDescription, int prodStock, double prodPrice, string imgUrl)
        {
            var newProduct = new Product
            {
                Prod_Name = prodName,
                Prod_Description = prodDescription,
                Prod_Stock = prodStock,
                Prod_Price = prodPrice,
                Prod_Image = imgUrl
            };
            tc.Products.InsertOnSubmit(newProduct);
            try
            {
                tc.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }
    }
} 
