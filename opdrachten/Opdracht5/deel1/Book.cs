using System;

class Book {
    private string name;
    private Author author;
    private double price;
    private int qtyInStock = 0;

    public Book (string name, Author author, double price, int qtyInStock) {
        this.name = name;
        this.author = author;
        this.price = price;
        this.qtyInStock = qtyInStock;
    }

    public string getName () {
        return this.name;
    }

    public Author getAuthor () {
        return this.author;
    }

    public double getPrice () {
        return this.price;
    }

    public void setPrice (double price) {
        this.price = price;
    }

    public int getQtyInStock () {
        return this.qtyInStock;
    }

    public void setQtyInStock (int qtyInStock) {
        this.qtyInStock = qtyInStock;
    }

    public void print () {
        Console.WriteLine("Name : " + name + "\nAuthor : " + getAuthorName() + "\nPrice : " + price + "\nQuantity in stock : " + qtyInStock);
    }

    public string getAuthorName () {
        return author.Name();
    }
}