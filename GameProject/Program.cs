using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEstateUserValidationService());

            gamerManager.Add(new Gamer 
            {
                Id = 1, 
                BirthYear = 1991, 
                FirstName = "DOĞAN", 
                LastName = "AKGÜN", 
                IdentityNumber = 12345 });

            Console.WriteLine("Hello World!");
        }
    }
}
