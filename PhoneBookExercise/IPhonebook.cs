using System;
namespace PhoneBookExercise
{
	public interface IPhonebook
	{
        ContactDetails GetContactDetailsById(int id);
        IEnumerable<ContactDetails> GetContactDetailsByFullName(string fullname);
        int GetContactsCountByPhonePrefix(string prefix);
        IEnumerable<ContactDetails> GetContactDetailsByNameContains(string str);
    }
}

