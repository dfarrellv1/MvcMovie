using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//when you create a new controller a folder in views is automatically created
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()//if you run the application and put "/HelloWorld" after the URL port number it will automatically print this from Index
        { //this is because of the default route in (folder) App_Start/RouteConfig.cs file, /helloworld maps to the HelloworldController class with this route


            //return "This is my <b>default</b> action...";
            //index can just be used to retun strings like this but we want to return views to make use of MVC

            return View(); //trying to do this will cause an error until we create a view in the associated view folder
            //we will create one using MVC 5 view page with layout (Razor) and using partial _layout.cshtml in the shared folder as a layout page
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        /*
        public string Welcome() //browsing to /HelloWorld/Welcome/ goes here
        {
            return "This is the Welcome action method...";
        }
        */

        //entering "3?name=john" after url goes to that route name = john, ID = 3, since RouteConfig goes "{controller}/{action}/{id}", ID is optional
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            //I was trying to return a view for a method of type string, changed the method to ActionResult
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);

            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}