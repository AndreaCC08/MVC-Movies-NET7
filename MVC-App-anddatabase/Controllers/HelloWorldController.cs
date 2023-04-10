using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC_App_anddatabase.Controllers
{
    public class HelloWorldController
    {
        //Get: /HelloWorld/
        public void Index(){}

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
