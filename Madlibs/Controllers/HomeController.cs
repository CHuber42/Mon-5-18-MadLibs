using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  { 
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; 
    }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; 
    }

    [Route("/")]
    public ActionResult Form() { return View(); 
    }

    [Route("/Madlib")]
    public ActionResult Madlib(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }
  }
}