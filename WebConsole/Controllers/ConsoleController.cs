using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roslyn.Scripting.CSharp;

namespace WebConsole.Controllers
{
    public class ConsoleController : Controller
    {
        //
        // GET: /Console/

        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult Run(string command)
        {
            var roslynEngine = new ScriptEngine();
            Roslyn.Scripting.Session session = roslynEngine.CreateSession();
            session.AddReference("System.Web");
            session.AddReference("System");
            session.AddReference("System.Core");
            session.AddReference("System.Collections");
            session.AddReference("System.Linq");
            session.AddReference("System.Xml");
            session.AddReference("System.Xml.Linq");
            session.ImportNamespace("System");
            session.ImportNamespace("System.IO");
            session.ImportNamespace("System.Linq");
            session.ImportNamespace("System.Xml.Linq");

            var res = session.Execute(command);

            return View(res);
        }
    }
}
