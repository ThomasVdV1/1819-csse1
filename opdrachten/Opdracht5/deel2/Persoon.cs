namespace deel2 {
    public class Persoon : Gebruiker, IInformatie {
        
        private string naam;
        private string voornaam;


        public string Voornaam {
            get {
                return this.voornaam;
            }
            set {
                this.voornaam = value;
            }
        }
        
        public string Naam {
            get;
            set;
        }

        public string VolledigeNaam {
            get;
        }

        public DateTime Geboortedatum {
            get;
            set;
        }

        public int Leeftijd() {
            return 0;
        }

        public string GenereerWachtwoord (string s) {
            return "Persoon - wachtwoord(s)";
        }

        public string GenereerWachtwoord (int i) {
            return "Persoon - wachtwoord(i)";
        }

        public override string GenereerWachtwoord () {
            return "Persoon - wachtwoord()";
        }

        // public int GenereerWachtwoord() {
        //     return 9;
        // }



        // public string ToString () {
        //     return "waaren van object persoon";
        // }

    }
}

