using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieLibrary.Controllers
{
    public class HelloWorldController : Controller
    {

        /*An HTTP endpoint is a targetable URL in the web application, such as https://localhost:5001/HelloWorld, and combines the protocol used: HTTPS, the network location of the web server (including the TCP port): localhost:5001 and the target URI HelloWorld.
         MVC invokes controller classes (and the action methods within them) depending on the incoming URL. The default URL routing logic used by MVC uses a format like this to determine what code to invoke:

        /[Controller]/[ActionName]/[Parameters]

           The routing format is set in the Configure method in Startup.cs file.*/
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            //Controller methods (also known as action methods), such as the Index method below, generally return an IActionResult (or a class derived from ActionResult), not a type like string.
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        /*Uses the C# optional-parameter feature to indicate that the numTimes parameter defaults to 1 if no value is passed for that parameter. */
        public string Welcome(string name, int ID = 1)
        {
            //Uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript). Also, uses Interpolated Strings.
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: { ID}");
        }
    }
}