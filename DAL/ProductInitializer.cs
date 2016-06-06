using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using armstrongkarate_.Models;

namespace armstrongkarate_.DAL
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        public object EnrollmentDate { get; private set; }

        protected override void Seed(ProductContext context)
        {
            var product = new List<product>
            {
                new product {pName="Rogue Xtreme Series MMA Gloves", Descrition="The Rogue Xtreme Series MMA Gloves have been designed specifically to offer maximum protection, functionality and flexibility to MMA fighters and enthusiasts everywhere!", Quantity="8",price= "24.99",EnrollmentDate=DateTime.Parse("2015-09-8")},
                new product {pName="Batton Nunchaku", Descrition="Batton Nunchaku. Two weapons in one. Twist and lock together to make a 16, Batton - un-twist and use as metal nunchaku.", Quantity="1",price= "15.99" },
                new product {pName="Blitz Adult Adult Odachi Karate Suit", Descrition="Hayabusa® has always been focused on delivering the very best performance equipment and apparel possible, and the new Champion Karate Gi is no exception. Specifically developed with 100% premium ", Quantity="2",price= "22.99",EnrollmentDate=DateTime.Parse("2015-10-15") },
                new product {pName="Adidas WTF Forearm Protectors", Descrition="WTF Approved Made PU, Two all around elastic straps with easy velcro closing tight fitting, CE Approved.", Quantity="2",price= "9.99" },
                new product {pName="Adidas Reversible Body Armour", Descrition="The ultimate approved reversible body armour, blue one side red the other, contains a shock absorbing EVA pad which is approximately 13mm thick. The shock absorbing pad of the protector also contains a sponge to protect the wearer from the shock of attacks", Quantity="1",price= "21.99",EnrollmentDate=DateTime.Parse("2016-01-6") },
                new product {pName="Bad Boy Kids Gamer T Shirt", Descrition="Bad Boy brings you the all new Kids Gamer Tee. Made from 100% cotton.", Quantity="1",price= "14.99", EnrollmentDate=DateTime.Parse("2016-01-10")},
                new product {pName="Century Versys VSPAR1 Kids", Descrition="he Versys V.SPAR.1, a versatile simulator designed specifically for youth, is ideal for inspiring physical activity including aerobic conditioning, endurance, speed, and technique training.", Quantity="1",price= "179.99",EnrollmentDate=DateTime.Parse("2016-03-17") },
                new product {pName="Blitz Target Master Multi Kick Punch Target Stand", Descrition="Your essential piece of dojo or gym equipment! A combination of 4 adjustable flexible paddles, that will test your speed and co-ordination to the max! Its central pole can easily be adjusted to ensure most heights are catered for as all paddles can be maneuvered. .", Quantity="4",price= "110.00", EnrollmentDate=DateTime.Parse("2016-04-28") },
                new product {pName="Black Eagle Karate Black Elite Belt", Descrition="Black Eagle Karate Black Belt. Cotton 300cm or 320cm Black belt with Karate in japaneese in gold embroidery.", Quantity="9",price= "8.99",EnrollmentDate=DateTime.Parse("2016-05-4") },
                new product {pName="The Story Of Shaolin DVD", Descrition="William Yen learned Shaolin Kung Fu at the age of five, specialising  in somersaulting, jumping and 'Plum fighting' skills. ", Quantity="1",price= "4.99", EnrollmentDate=DateTime.Parse("2016-05-25")},
            };

            product.ForEach(s => context.Products.Add(s));
            context.SaveChanges();  

            var Customer = new List<Customer>
            {
                new Customer {Tle="Mr",SName="Hung",FName="Micahel",EnrollmentDate=DateTime.Parse("2016-01-6")},
                new Customer {Tle="Mr",SName="James",FName="Pearline",EnrollmentDate=DateTime.Parse("2016-01-10")},
                new Customer {Tle="Miss",SName="McKeniz",FName="Charlotte",EnrollmentDate=DateTime.Parse("2016-02-18")},
                new Customer {Tle="Mr",SName="Tyler",FName="Ko",EnrollmentDate=DateTime.Parse("2016-02-20")},
                new Customer {Tle="Mr",SName="Williams",FName="John",EnrollmentDate=DateTime.Parse("2016-03-2")},
                new Customer {Tle="Mr",SName="Pongo",FName="David",EnrollmentDate=DateTime.Parse("2016-03-11")},
                new Customer {Tle="Mrs",SName="Cheung",FName="Kitty",EnrollmentDate=DateTime.Parse("2016-04-3")},
                new Customer {Tle="Mrs",SName="Dobblins",FName="Laura",EnrollmentDate = DateTime.Parse("2016-05-4") },
                new Customer {Tle="Miss",SName="Percel",FName="Ewa",EnrollmentDate=DateTime.Parse("2016-05-30")},

            };
            Customer.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
        }
    }
}