
namespace AgendaContactosWinForms
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, string phonenumber, string email)
        {
            Name = name;
            PhoneNumber = phonenumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nombre: {Name}, Numero de contacto: {PhoneNumber}, Correo: {Email}";
        }
    }
}
