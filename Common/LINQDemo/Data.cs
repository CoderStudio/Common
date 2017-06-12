using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public static class Data
    {
        public static List<Person> GetPersonlist()
        {
            var list = new List<Person>
            {
                new Person {id =1 , Name = "Peter1" },
                new Person {id =2 , Name = "Peter2" },
                new Person {id =3 , Name = "Peter3" },
                new Person {id =4 , Name = "Peter4" },
            };
            return list;
        }

        public static List<Pet> GetPetlist()
        {
            var list = new List<Pet>
            {
                new Pet {id =3 , Name = "Peter3",Owner="test1" },
                new Pet {id =4 , Name = "Peter2",Owner="test2" },
                new Pet {id =5 , Name = "Peter3",Owner="test3" },
                new Pet {id =6 , Name = "Peter4",Owner="test4" },
            };
            return list;
        }
    }

    public class Person
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

    public class Pet
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
    }
   
}
