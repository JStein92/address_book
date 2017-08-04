using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(Contact.GetAll());
    }

    [HttpPost("/contact/new")]
    public ActionResult ContactNew()
    {
      string name = Request.Form["name"];
      string phone = Request.Form["phone"];
      string street = Request.Form["street"];
      string city = Request.Form["city"];
      string state = Request.Form["state"];
      string notes = Request.Form["notes"];
      Address newAddress = new Address(street,city,state);
      Contact newContact = new Contact(name,phone,newAddress,notes);

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
