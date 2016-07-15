using System;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phoneNumber;
    private static List<Contact>_instances = new List<Contact> {};

    public Contact(string name, string address, string phone)
    {
      _name = name;
      _address = address;
      _phoneNumber = phone;
    }
    public string GetName()
    {
      return _name;
    }
    public string GetAddress()
    {
      return _address;
    }
    public string GetPhone()
    {
      return _phoneNumber;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public void SetPhone(string newNumber)
    {
      _phoneNumber = newNumber;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
  }
}
