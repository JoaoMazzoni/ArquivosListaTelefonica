using System.Collections.Generic;

namespace AgendaTelefone
{
    internal class Contact
    {
        public string name { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public List<Phone> phones { get; set; }

        public Contact(string name, string email, Address address, List<Phone> phones)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            this.phones = phones; // Corrigido para atribuir a lista de telefones fornecida
        }

        public override string ToString()
        {
            string contactString = $"Nome: {name}\nEmail: {email}";
            contactString += $"\nRua: {address.street}, {address.number}\nBairro{address.neighborhood}\nCidade: {address.city}\nCEP: {address.postcode}\n";
            contactString += "\nTelefones:\n";

            foreach (var phone in phones)
            {
                contactString += $"\nNúmero: {phone.phone}\n";
            }
            return contactString;
        }
    }
}
