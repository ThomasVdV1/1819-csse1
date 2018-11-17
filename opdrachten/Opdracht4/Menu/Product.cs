class Product: Prijs
{
    public string naam {get;set;}
    public string type {get;set;}

    public Product () {
        this.naam = "Onbekend";
        this.type = "Onbekend";
    }

    public Product (string naam) {
        this.naam = naam;
        this.type = "Onbekend";
    }

    public Product (string naam, string type) {
        this.naam = naam;
        this.type = type;
    }
}