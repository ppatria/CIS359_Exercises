﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class ContactsLibrary   {


        public const string LibraryName = "Contacts";
        public string ContactName = string.Empty;
        public Contact ContactDetails { get; set; }
        
        public ContactsLibrary(string name) 
        {
            ContactName = name;
        }
    
        public int CreateContact(Contact newContact)
        {
            int retVal = 0;

            Contact contactToAdd = new Contact()
            {
                Title = newContact.Title,
                FirstName = newContact.FirstName,
                LastName = newContact.LastName,
                Email = newContact.Email,
                WorkPhone = newContact.WorkPhone,
                CellPhone = newContact.CellPhone,
                Description = newContact.Description,
                Notes = newContact.Notes, 

            };
            // Process new contact and save to the database returning the new contactID

            return retVal;

        }

        public Contact getContact(int contactID)
        {
            Contact contact = null;

            // Get contact info from database and return the contact

            return contact;
        }

        public bool updateContact(Contact contactToUpdate)
        {
            bool retVal = false;

            // Process update request and return true to indicate successful update

            return retVal;
        }

        public bool deleteContact(int contactID)
        {
            bool retVal = false;

            // Delete contact and return true to indicate successful deletion

            return retVal;
        }

    }

    public class Contact
    {
        public ContactTitle Title;
        public string FirstName;
        public string LastName;
        public string Email;
        public string WorkPhone;
        public string CellPhone;
        public string Description;
        public string Notes;
    }

    public enum ContactTitle
    {
        Mr,
        Mrs,
        Miss,
        Mz,
        Dr
    }


}