
namespace AgendaTelefone
{
    internal class Address
    {
        public string street {  get; set; }
        public string city { get; set; }
        public string number { get; set; }
        public string neighborhood { get; set; }
        public string postcode { get; set; }

        public Address(string street, string city, string number, string neighborhood, string postcode)
        {
            this.street = street;
            this.city = city;
            this.number = number;
            this.neighborhood = neighborhood;
            this.postcode = postcode;
        }

       
        public override string? ToString()
        {
            return $"\nCidade: {this.city}\nRua: {this.street}, {this.number}\nBairro: {this.neighborhood}\nCEP: {this.postcode}";
        }

    }

}
