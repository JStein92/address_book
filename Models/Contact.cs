using AddressBook.Models;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _notes;
    private Address _address;
    private int _id;
    private static List<Contact> _allContacts = new List<Contact>();

    public Contact(string name, string phone, Address address, string notes = "")
    {
      _name = name;
      _phone = phone;
      _address = address;
      _notes = notes;
      _allContacts.Add(this);
      _id = _allContacts.Count;
    }

    public string GetName()
    {
      return _name;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public string GetNotes()
    {
      return _name;
    }
    public Address GetAddress()
    {
      return _address;
    }
    public int GetId()
    {
      return _id;
    }
    public List<Contact> GetAll()
    {
      return _allContacts;
    }
    public Contact Find(int searchId)
    {
      return _allContacts[searchId - 1];
    }

  }
}
