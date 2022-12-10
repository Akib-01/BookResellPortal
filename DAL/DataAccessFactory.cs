﻿using DAL.EF;
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
        public static IRepo<Registration, int, Registration> RegistratonDataAccess() { return new RegistrationRepo(); }
        public static IRepo<Product,int,Product> ProductDataAccess() { return new ProductRepo(); }
        public static IRepo<Cart,int,Cart> CartDataAccess() { return new CartRepo(); }
    }
}