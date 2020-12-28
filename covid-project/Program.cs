using System;

namespace covid_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen cit1 = new Citizen("mhmd","UC15554");
            cit1.isAffected = true;
            Cure cure1 = new Cure();
            cure1.name = "covidKiller";
            cure1.isSafe = false;
        }
    }
}
