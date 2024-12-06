using Ficha21.Models;

namespace Ficha21.Services
{
    public class ContactRepository
    {
        //lista de contatos
        private List<Contact> listContacts = new List<Contact>();

        public ContactRepository()
        {
            Contact c1 = new Contact("João Silva", "1");
            Contact c2 = new Contact("Maria Lopes", "2");

            listContacts.Add(c1);
            listContacts.Add(c2);
        }

        //GetAllContacts
        public List<Contact> GetAllContacts()
        {
            return listContacts;
        }

        //AddContact
        public void AddContact(Contact contact)
        {
            listContacts.Add(contact);
        }


        //GetContactById
        public Contact? GetContactById(string id)
        {

            foreach(Contact c in listContacts)
            {
                if(c.Id.Equals(id))
                {
                    return c;
                }
            }
            return null;
        }

        //UpdateContact
        public bool UpdateContact(Contact contact)
        {
            for (int i = 0; i < listContacts.Count; i++)
            {
                if (listContacts[i].Id.Equals(contact.Id))
                {
                    listContacts[i].Name = contact.Name;
                    return true;

                }
            }
            return false;
        }

        //DeleteContact
        public bool DeleteContact(string id)
        {
            for (int i = 0; i < listContacts.Count; i++)
            {
                if (listContacts[i].Id.Equals(id))
                {
                    listContacts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}