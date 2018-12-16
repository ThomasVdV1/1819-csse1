using System;

namespace deel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p1 = new Persoon();
            Console.WriteLine(p1.GenereerWachtwoord());

            Student s1 = new Student();
            Console.WriteLine(s1.GenereerWachtwoord());

            // Het protected veld 'wachtwoord' in 'Gebruiker' moet een waarde kunnen krijgen, dus moet er een contructor of property zijn.
            // (Staat niet in het UML-schema)

            // De variabele in 'Persoon' moet een 'DateTime' variabele zijn ipv. een 'Date' variabele.
            // De functie 'string GenereerWachtwoord()' in 'Persoon' moet de gelijknamige functie in 'Gebruiker' overschrijven.
            // De functie 'int GenereerWachtwoord()' kan niet toegevoegd worden aangezien er al een gelijknamige functie is met
            // dezelfde parameters (geen).

            // De functie 'string GenereerWachtwoord()' in 'Student' moet de gelijknamige functie in 'Persoon' overschrijven.

            // Het protected veld 'campusNummer' en het private veld 'afkortingCampus' in 'Opleiding' moeten een waarde kunnen krijgen, 
            // dus moet er een contructor of property zijn.
            // (Staat niet in het UML-schema)
        }
    }
}
