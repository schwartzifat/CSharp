using System;
using System.Text;

namespace PhoneBookExercise
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
}

