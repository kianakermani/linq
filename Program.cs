using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<person> people = new List<person>();
            person P1 = new person();
            P1.PersonID = 1;
            P1.Name = "kiana";
            P1.Family = "kermani";
            P1.Age = 20;
            people.Add(P1);

            person p2 = new person() {
                PersonID = 2,
                Name = "sara",
                Family="saraei",
                Age=19
            };
            people.Add(p2);

            people.Add(new person() { PersonID = 3, Name = "ali", Family = "rezaei", Age = 18 }) ;
             var result1 = people.OrderByDescending(p=>p.Age).ToList();
            foreach(var p in result1)
            {
                Console.WriteLine($"ID : {p.PersonID} Name : {p.Name} Family : {p.Family} Age :{p.Age}");
            }

            List<PersonCar> Cars = new List<PersonCar>()
            {
                new PersonCar() { PersonID =1 , CarName ="Pride", CarModel="1380"},
                new PersonCar() {PersonID =2 , CarName ="Peykan",CarModel="1385"}

            };

            var join = (from p in people join c in Cars on p.PersonID equals c.PersonID select new { p.PersonID, p.Name, p.Family, p.Age, c.CarName, c.CarModel }).ToList();

        }
    }
}
