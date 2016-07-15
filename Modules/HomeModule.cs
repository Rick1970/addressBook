using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Get["/add_new_contact"] = _ =>{
        return View["add_new_contact.cshtml"];
      };
      Post["/contact_added"] = _ =>{
        Contact oneContact = new Contact(Request.Form["name"], Request.Form["address"], Request.Form["phone"]);
        oneContact.Save();
        return View["/contact_created.cshtml", oneContact];
      };
      Get["/all_contacts"] = _ =>{
        List<Contact> allContacts = Contact.GetAll();
        return View["all_contacts.cshtml",allContacts];
      };
      Post["/contacts_cleared"] = _ =>{
        Contact.DeleteAll();
        return View["contacts_deleted.cshtml"];
      };

    }
  }
}
