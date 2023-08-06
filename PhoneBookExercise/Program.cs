using System.Text;
namespace PhoneBookExercise;
class Program
{
    static void Main(string[] args)
    {
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

