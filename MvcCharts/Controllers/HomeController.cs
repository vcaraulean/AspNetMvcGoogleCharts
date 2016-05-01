using System.Web.Mvc;
using MvcCharts.Models;
using Newtonsoft.Json;

namespace MvcCharts.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetChartData()
        {
            var dt = new VisualizationDataTable();
            dt.AddColumn("Date", "string");
            dt.AddColumn("Events", "number");
            dt
                .NewRow("25-05-2016", 123)
                .NewRow("26-05-2016", 111)
                .NewRow("27-05-2016", 132)
                .NewRow("28-05-2016", 121)
                .NewRow("29-05-2016", 109)
                .NewRow("30-05-2016", 126)
                ;

            var chart = new ChartViewModel
            {
                Title = "Events",
                Subtitle = "per date",
                DataTable = dt
            };

            return Content(JsonConvert.SerializeObject(chart), "application/json");
        }
    }
}