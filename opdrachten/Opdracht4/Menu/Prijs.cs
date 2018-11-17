class Prijs
{
    public string valuta {get; set;}
    public double waarde {get; set;}

    public Prijs() {
        valuta = "Euro";
        waarde = 0;
    }

    public Prijs(string valuta) {
        this.valuta = valuta;
        this.waarde = 0;
    }

    public Prijs(double waarde) {
        this.valuta = "Euro";
        this.waarde = waarde;
    }

    public Prijs(string valuta, double waarde) {
        this.valuta = valuta;
        this.waarde = waarde;
    }
}