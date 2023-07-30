using System.Text;
namespace PhoneBookExercise;
class Program
{
    public class ContactDetails
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string[] Phones { get; set; }


        public override string ToString()
        {
            return $"ID: {ID}, Full Name: {FullName}, City: {City}, Phones: {string.Join(", ", Phones)}";
        }
    }


    public interface IPhonebook
    {
        ContactDetails GetContactDetailsById(int id);
        IEnumerable<ContactDetails> GetContactDetailsByFullName(string fullname);
        int GetContactsCountByPhonePrefix(string prefix);
        IEnumerable<ContactDetails> GetContactDetailsByNameContains(string str);

    }

    public class Phonebook : IPhonebook
    {
        private List<ContactDetails> contacts = new List<ContactDetails>();
        public ContactDetails GetContactDetailsById(int id)
        {
            return contacts.Find(contact => contact.ID == id);
        }

        public IEnumerable<ContactDetails> GetContactDetailsByFullName(string fullname)
        {
            foreach(ContactDetails contact in contacts)
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
            foreach(ContactDetails contact in contacts)
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

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Phonebook phonebook = new Phonebook();

        phonebook.AddContactDetails(new ContactDetails { ID = 23221, FullName = "Ifat Schwartz", City = "Tel Aviv", Phones = new string[] { "054-8002004", "077-2055987" } });
        phonebook.AddContactDetails(new ContactDetails { ID = 23222, FullName = "Eran Schwartz", City = "Tel Aviv", Phones = new string[] { "054-8002005", "077-2055988" } });
        phonebook.AddContactDetails(new ContactDetails { ID = 23223, FullName = "Agam Schwartz", City = "Tel Aviv", Phones = new string[] { "052-8002006", "077-2055989" } });
        phonebook.AddContactDetails(new ContactDetails { ID = 23224, FullName = "Romi Schwartz", City = "Tel Aviv", Phones = new string[] { "052-8002007", "077-2055990" } });
        phonebook.AddContactDetails(new ContactDetails { ID = 23225, FullName = "Yonatan Schwartz", City = "Tel Aviv", Phones = new string[] { "052-8002008", "077-2055991" } });

        ContactDetails contactById = phonebook.GetContactDetailsById(23223);
        Console.WriteLine(contactById);

        IEnumerable<ContactDetails> contactsByFullName = phonebook.GetContactDetailsByFullName("Eran Schwartz");
        foreach (ContactDetails contact in contactsByFullName)
        {
            Console.WriteLine(contact);
        }

        int countOfPrefix = phonebook.GetContactsCountByPhonePrefix("052");
        Console.WriteLine($"Number of contacts with phone prefix '052' {countOfPrefix}");

        IEnumerable<ContactDetails> contactsWithName = phonebook.GetContactDetailsByNameContains("an");
        foreach ( ContactDetails contact in contactsWithName)
        {
            Console.WriteLine(contact);
        }

    }
}

