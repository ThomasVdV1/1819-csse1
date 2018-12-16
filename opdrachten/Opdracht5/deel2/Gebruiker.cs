namespace deel2 {
    
    public class Gebruiker {

        protected string wachtwoord;

        public string Gebruikersnaam {
            get;
            set;
        }

        public virtual string GenereerWachtwoord () {
            return "Gebruiker - wachtwoord";
        }

        public void GenereerGebruikersnaam () {
            this.Gebruikersnaam = "test";
        }

        public Gebruiker() {
            //niet veilign want: geen hashing
            this.wachtwoord = GenereerWachtwoord();
        }

    }
    
}

