using Microsoft.AspNetCore.Mvc;
using Madlib.Models;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Home() { return View(); 
    }

    [Route("/FormB")]
    public ActionResult FormB() { return View(); 
    }
    
    [Route("/FormA")]
    public ActionResult FormA() { return View(); 
    }

    [Route("/MadlibA")]
    public ActionResult MadlibA(string noun1, string noun2, string noun3, string verb1, string adjective1, string adjective2)
    {
      MadlibVariable myMadlibVariable = new MadlibVariable(noun1, noun2, noun3, verb1, adjective1, adjective2);
      return View(myMadlibVariable);
    }

    [Route("/MadlibB")]
    public ActionResult MadlibB(string color1, string verb1, string liquid, string noun2, string pastverb, string time)
    {
      MadlibVariableB myMadlibVariableB = new MadlibVariableB(color1, verb1, liquid, noun2, pastverb, time);
      return View(myMadlibVariableB);
    }
  }
}