using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;
using System;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(Contact.GetAll());
    }

    [HttpPost("/clear/{id}")]
    public ActionResult Index(int id)
    {
      Contact.ClearContact(id);
      return View(Contact.GetAll());
    }

    [HttpPost("/contacts/clear")]
    public ActionResult ClearConfirmation()
    {
      Contact.ClearAll();
      return View();
    }

    [HttpPost("/index")]
    public ActionResult IndexEditContact()
    {
      string name = Request.Form["name"];
      string phone = Request.Form["phone"];
      string street = Request.Form["street"];
      string city = Request.Form["city"];
      string state = Request.Form["state"];
      string notes = Request.Form["notes"];

      Address editedAddress = new Address(street,city,state);
      Contact editedContact = new Contact(name,phone,editedAddress,false,notes);

      Console.WriteLine("Contact to edit is: " + name + " at position " + Request.Form["Id"]);

      editedContact.SetId(Contact.Find(int.Parse(Request.Form["Id"])).GetId());
      Contact.EditContact(editedContact);
      return View("index", Contact.GetAll());
    }

    [HttpPost("/contact/new")]
    public ActionResult ContactNew()
    {
        Console.WriteLine("New contact is created");
        string name = Request.Form["name"];
        string phone = Request.Form["phone"];
        string street = Request.Form["street"];
        string city = Request.Form["city"];
        string state = Request.Form["state"];
        string notes = Request.Form["notes"];
        Address newAddress = new Address(street,city,state);
        Contact newContact = new Contact(name,phone,newAddress,true,notes);
        return View(newContact);
      }

    [HttpGet("/ContactForm")]
    public ActionResult ContactForm()
    {
      return View();
    }

    [HttpGet("/ContactDetails/{id}")]
    public ActionResult ContactDetails(int id)
    {
      return View(Contact.Find(id));
    }

  }
}
