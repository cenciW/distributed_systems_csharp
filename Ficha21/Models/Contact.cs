namespace Ficha21.Models
{
    public class Contact
    {
        public Contact(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public Contact()
        {
            
        }

        //getter e setter
        public string Name { get; set; }
        public string Id { get; set; }

    }
}
