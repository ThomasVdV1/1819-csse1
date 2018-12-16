using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a = new Author("Joris", "joris@gmail.com", 'M');
            Book b = new Book("boek1", a, 3.99, 7);
            b.print();
        }
    }
}
