using System;

namespace covid_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Location so9 = new Location();
            Person p1 = new Person("abdellah0", "uc4555", 20);
            Person p2 = new Person("abdellah1", "uc4555", 20);
            Person p3 = new Person("abdellah2", "uc4555", 20);
            Person p4 = new Person("abdellah3", "uc4555", 20);
            Person p5 = new Person("abdellah4", "uc4555", 20);
            Person p6 = new Person("abdellah5", "uc4555", 20);
            Person p7 = new Person("abdellah6", "uc4555", 20);
            Person p8 = new Person("abdellah7", "uc4555", 20);

            p1.isAffected = true;

            so9.peoplePedningTest.Add(p1);
            so9.peoplePedningTest.Add(p2);
            so9.peoplePedningTest.Add(p3);
            so9.peoplePedningTest.Add(p4);
            so9.peoplePedningTest.Add(p5);
            so9.peoplePedningTest.Add(p6);
            so9.peoplePedningTest.Add(p7);
            so9.peoplePedningTest.Add(p8);

            for(int i = 0; i< so9.peoplePedningTest.Count; i++)
                Console.WriteLine(so9.peoplePedningTest[i].personName);

            so9.generatePeoplePendingTest();

            p5.generateColorCode();
            Console.WriteLine(p5.colorCode);
        }
    }
}
