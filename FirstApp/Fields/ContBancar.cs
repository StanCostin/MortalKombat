namespace Fields
{
    public class ContBancar
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string nume;
        public string Nume { 
            get 
            {
                return nume;
            }
            set
            {
                nume = value;
            }
        }
        string prenume;

        string cnp;
        public string Cnp
        {
            get
            {
                return cnp;
            }
        }
        string adresa;
        public string Adresa
        {
            set
            {
                adresa = value;
            }
        }
        protected string Iban { get; set; }

        public decimal Sold { get; protected set; }
        Valuta valuta;
    }
}