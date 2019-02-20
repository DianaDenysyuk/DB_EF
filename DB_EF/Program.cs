using DB_EF.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MarketModel db = new MarketModel())
            {
                Building b1 = new Building { Number = 3, Latter = "a" };
                Building b2 = new Building { Number = 27, Latter = "d" };
                Building b3 = new Building { Number = 4, Latter = "b" };
                Building b4 = new Building { Number = 9, Latter = "ab" };
                Country c1 = new Country { Name = "Ukraine", ShortName = "UA", CityName = "Rivne" };
                Country c2 = new Country { Name = "United States of America", ShortName = "USA", CityName = "Chicago" };
                Country c3 = new Country { Name = "South Korea", ShortName = "KR", CityName = "Daegu" };
                Country c4 = new Country { Name = "Israel", ShortName = "IL", CityName = "Jerusalem" };
                Category ctgr1 = new Category { Name = "Clothes", Description = "The clothes a person wears tells us many things: their status in life, for example, or their cultural affiliation or identity. They can tell us what era they live in, and even a person’s current state of mind or intent. Understanding how to describe clothing in a story well will help you create fuller, richer character portraits.", IsLegal = true };
                Category ctgr2 = new Category { Name = "Fruits", Description = "In botany, a fruit is the seed-bearing structure in flowering plants (also known as angiosperms) formed from the ovary after flowering.", IsLegal = true };
                Category ctgr3 = new Category { Name = "Vegetables", Description = "Vegetables are parts of plants that are consumed by humans or other animals as food.", IsLegal = true };
                Category ctgr4 = new Category { Name = "Technology", Description = "Technology is the collection of techniques, skills, methods, and processes used in the production of goods or services or in the accomplishment of objectives, such as scientific investigation.", IsLegal = false };
                Status s1 = new Status { Name = "Admin" };
                Status s2 = new Status { Name = "Moderator" };
                Status s3 = new Status { Name = "Buyer" };
                Status s4 = new Status { Name = "Male" };
                Status s5 = new Status { Name = "Female" };
                Status s6 = new Status { Name = "Disabled" };
                Adress a1 = new Adress { Country = c1, Building = b1 };
                Adress a2 = new Adress { Country = c2, Building = b2 };
                Adress a3 = new Adress { Country = c3, Building = b3 };
                Adress a4 = new Adress { Country = c4, Building = b4 };
                User u1 = new User { Login = "diana1234", Password = "1234diana", Age = 15, Email = "dianaBorahae@gmail.com", Gender = s5, Status = s3 };
                User u2 = new User { Login = "TaeTae", Password = "19951230v", Age = 23, Email = "vante@gmail.com", Gender = s4, Status = s3 };
                User u3 = new User { Login = "dendi", Password = "dendidendi427", Age = 19, Email = "didenysyuk@gmail.com", Gender = s5, Status = s1 };
                User u4 = new User { Login = "mama", Password = "mamaloveyou", Age = 18, Email = "mama@gmail.com", Gender = s5, Status = s1 };
                AbstractProduct ap1 = new AbstractProduct { Name = "T-shirt", Category = ctgr1 };
                AbstractProduct ap2 = new AbstractProduct { Name = "Apple", Category = ctgr2 };
                AbstractProduct ap3 = new AbstractProduct { Name = "Cucumber", Category = ctgr3 };
                AbstractProduct ap4 = new AbstractProduct { Name = "Phone", Category = ctgr4 };
                Producer p1 = new Producer { Name = "Guess", Adress = a2 };
                Producer p2 = new Producer { Name = "IsraelFruits", Adress = a4 };
                Producer p3 = new Producer { Name = "UVC", Adress = a1 };
                Producer p4 = new Producer { Name = "Samsung", Adress = a3 };
                RealProduct rp1 = new RealProduct { Price = 20, ProductionDate = new DateTime(2018, 4, 18), ExpiresDate = new DateTime(2068, 4, 18), Quantity = 200, Producer = p1, AbsProduct = ap1 };
                RealProduct rp2 = new RealProduct { Price = 3, ProductionDate = new DateTime(2019, 2, 20), ExpiresDate = new DateTime(2019, 2, 28), Quantity = 3500, Producer = p2, AbsProduct = ap2 };
                RealProduct rp3 = new RealProduct { Price = 1, ProductionDate = new DateTime(2019, 2, 20), ExpiresDate = new DateTime(2019, 3, 6), Quantity = 2750, Producer = p3, AbsProduct = ap3};
                RealProduct rp4 = new RealProduct { Price = 1050, ProductionDate = new DateTime(2017, 12, 12), ExpiresDate = new DateTime(2067, 12, 12), Quantity = 50000, Producer = p4, AbsProduct = ap4 };
                Order o1 = new Order { OrderDate = new DateTime(2018, 2, 20), Quantity = 2, DeliveryAdress = a1, RealProduct = rp1, User = u1 };
                Order o2 = new Order { OrderDate = new DateTime(2018, 2, 10), Quantity = 20, DeliveryAdress = a2, RealProduct = rp2, User = u3 };
                Order o3 = new Order { OrderDate = new DateTime(2018, 1, 30), Quantity = 15, DeliveryAdress = a4, RealProduct = rp3, User = u4 };
                Order o4 = new Order { OrderDate = new DateTime(2018, 1, 24), Quantity = 1, DeliveryAdress = a3, RealProduct = rp4, User = u2 };
                db.Buildings.Add(b1);
                db.Buildings.Add(b2);
                db.Buildings.Add(b3);
                db.Buildings.Add(b4);
                db.Countries.Add(c1);
                db.Countries.Add(c2);
                db.Countries.Add(c3);
                db.Countries.Add(c4);
                db.Category.Add(ctgr1);
                db.Category.Add(ctgr2);
                db.Category.Add(ctgr3);
                db.Category.Add(ctgr4);
                db.Statuses.Add(s1);
                db.Statuses.Add(s2);
                db.Statuses.Add(s3);
                db.Statuses.Add(s4);
                db.Statuses.Add(s5);
                db.Statuses.Add(s6);
                db.Adresses.Add(a1);
                db.Adresses.Add(a2);
                db.Adresses.Add(a3);
                db.Adresses.Add(a4);
                db.Users.Add(u1);
                db.Users.Add(u2);
                db.Users.Add(u3);
                db.Users.Add(u4);
                db.AbstractProducts.Add(ap1);
                db.AbstractProducts.Add(ap2);
                db.AbstractProducts.Add(ap3);
                db.AbstractProducts.Add(ap4);
                db.Producers.Add(p1);
                db.Producers.Add(p2);
                db.Producers.Add(p3);
                db.Producers.Add(p4);
                db.RealProducts.Add(rp1);
                db.RealProducts.Add(rp2);
                db.RealProducts.Add(rp3);
                db.RealProducts.Add(rp4);
                db.Orders.Add(o1);
                db.Orders.Add(o2);
                db.Orders.Add(o3);
                db.Orders.Add(o4);
                db.SaveChanges();
            }
        }
    }
}
