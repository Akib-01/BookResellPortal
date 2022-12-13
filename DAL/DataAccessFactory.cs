using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Registration, int, Registration> RegistrationDataAccess() { return new RegistrationRepo(); }
        public static IRepo<Product, int, Product> ProductDataAccess() { return new ProductRepo(); }
        public static IRepo<Cart, int, Cart> CartDataAccess() { return new CartRepo(); }
        public static IRepo<Admin, int, Admin> AdminDataAccess() { return new AdminRepo(); }
        public static IRepo<TrackOrder, int, TrackOrder> TrackOrderDataAccess() { return new TrackOrderRepo(); }
    }
}
