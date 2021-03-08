using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact contactObj)
        {
            try
            {
                Contacts.Add(contactObj.Email, contactObj);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("something went wrong; contact already added");
            }
        }

        public Contact GetByEmail(string email)
        {
            try
            {
                return Contacts[email];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("This email address was not found.");
                return null;
            }
        }
    }
}