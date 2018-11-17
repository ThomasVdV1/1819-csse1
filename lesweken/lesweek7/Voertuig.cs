class Voertuig {
    // velden
    private int laadvermogen;
    private bool motor;

    // properties
    public int Laadvermogen {
        get;
        set;
    }

    // bool Motor {
    //     get;
    //     set;
    // }

    // methodes
    // constructors...
    public Voertuig () {

    }

    public Voertuig (int laadvermogen) {
        Laadvermogen = laadvermogen;
    }
}