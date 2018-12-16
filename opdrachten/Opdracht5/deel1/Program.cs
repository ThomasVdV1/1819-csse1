using System;

namespace deel1
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a = new Author("Joris", "joris@gmail.com", 'M');
            Book b = new Book("boek1", a, 3.99, 7);
            b.print();

            // Aangezien de velden van de 'Author' private moeten staan en geen property mag zijn, 
            // moeten de waarden van deze velden bij een instantie bepaald worden dmv. een constructor. (Wat niet in het UML-schema staat.)
            // (of dmv. een functie om deze later een waarde te geven.)

            // Ook moet de 'Author' een functie hebben om de waarde van de 'Name' op te vragen (vanuit een andere klasse), (Wat ook niet in het UML-schema staat.)
            // Aangezien dit veld private is.
        }
    }
}
