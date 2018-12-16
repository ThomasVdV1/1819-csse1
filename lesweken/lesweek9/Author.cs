class Author {
    private string name;
    private string email;
    private char gender;

    public Author (string name, string email, char gender) {
        this.name = name;
        this.email = email;
        this.gender = gender;
    }

    public string Name () {
        return this.name;
    }
}