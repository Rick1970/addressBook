using System;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _address;
    private int _phoneNumber

    public Contact(string name, string address, int phone)
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
    public int GetPhone()
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
    public void SetPhone(int newNumber)
    {
      _phoneNumber = newNumber;
    }
    
  }
}
