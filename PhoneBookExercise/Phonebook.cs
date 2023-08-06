using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookExercise
{
	public class Phonebook
	{
        private List<ContactDetails> contacts = new List<ContactDetails>();
        public ContactDetails GetContactDetailsById(int id)
        {
            return contacts.Find(contact => contact.ID == id);
        }

        public IEnumerable<ContactDetails> GetContactDetailsByFullName(string fullname)
        {
            foreach (ContactDetails contact in contacts)
            {
                if (contact.FullName.Equals(fullname))
                {
                    yield return contact;
                }
            }
        }

        public int GetContactsCountByPhonePrefix(string prefix)
        {
            return contacts.Count(contact => contact.Phones.Any(phone => phone.StartsWith(prefix)));
        }

        public IEnumerable<ContactDetails> GetContactDetailsByNameContains(string str)
        {
            foreach (ContactDetails contact in contacts)
            {
                if (contact.FullName.Contains(str))
                {
                    yield return contact;
                }
            }
        }

        public void AddContactDetails(ContactDetails contactDetails)
        {
            contacts.Add(contactDetails);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ContactDetails contact in contacts)
            {
                sb.AppendLine(contact.ToString());
            }
            return sb.ToString();
        }
    }
}


