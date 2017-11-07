using ChartJS.Helpers.MVC;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class RadarChartsController : Controller
    {
        public ActionResult Basic()
        {
            ChartTypeRadar chart = new ChartTypeRadar()
            {
                Data = new RadarData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new RadarDataSets[]
                    {
                        new RadarDataSets()
                        {
                            Label = "Dataset 1",
                            BackgroundColor = "rgba(0, 255, 0, 0.5)",
                            BorderColor = "green",
                            BorderWidth = 1,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new RadarDataSets()
                        {
                            Label = "Dataset 2",
                            BackgroundColor = "rgba(0, 0, 255, 0.5)",
                            BorderColor = "blue",
                            BorderWidth = 1,
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 }
                        }
                    }
                },
                Options = new RadarOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Radar Chart" }
                    },
                    Legend = new ChartOptionsLegend()
                    {
                        Position = ConstantPosition.TOP,
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
    }
}