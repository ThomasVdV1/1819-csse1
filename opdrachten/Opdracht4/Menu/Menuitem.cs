using System;
using System.Collections.Generic;

class Menuitem : Product {
    
    public Product itemProduct {get;set;}
    // public Prijs itemPrijs {get;set;}

    public Menuitem () {
        itemProduct = new Product();
        itemProduct.valuta = "Euro";
        itemProduct.waarde = 0;
    }

    public Menuitem (double prijsWaarde) {
        itemProduct = new Product();
        itemProduct.valuta = "Euro";
        itemProduct.waarde = prijsWaarde;
    }

    public Menuitem (string productNaam, double prijsWaarde) {
        itemProduct = new Product(productNaam);
        itemProduct.valuta = "Euro";
        itemProduct.waarde = prijsWaarde;
    }

    public Menuitem (string productNaam, string productType, double prijsWaarde) {
        itemProduct = new Product(productNaam, productType);
        itemProduct.valuta = "Euro";
        itemProduct.waarde = prijsWaarde;
    }


    public Menuitem (string productNaam, string productType, string valuta, double prijsWaarde) {
        itemProduct = new Product(productNaam, productType);
        itemProduct.valuta = valuta;
        itemProduct.waarde = prijsWaarde;
    }


    override public string ToString () {
        return itemProduct.naam + " (" + itemProduct.type + ") : " + itemProduct.waarde + " " + itemProduct.valuta;
    }
}