using ChartJS.Helpers.MVC;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class MixChartsController : Controller
    {
        // GET: Mix
        public ActionResult Basic()
        {
            ChartTypeMix chart = new ChartTypeMix()
            {
                Data = new MixData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new MixDataSets[]
                    {
                        new MixDataSets()
                        {
                            Label = "Dataset Bar 1",
                            BackgroundColor = "green",
                            BorderColor = "green",
                            BorderWidth = 1,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new MixDataSets()
                        {
                            Label = "Dataset Bar 2",
                            BackgroundColor = "blue",
                            BorderColor = "blue",
                            BorderWidth = 1,
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 }
                        }
                        ,
                        new MixDataSets()
                        {
                            Type = ConstantType.LINE,
                            Label = "Dataset Line 3",
                            BackgroundColor = "rgba(255, 0, 0, 0.5)",
                            BorderColor = "red",
                            BorderWidth = 1,
                            LinearData = new int[]{ 5, 54, 40, 0, 50, -43, 36 }
                        }
                    }
                },
                Options = new BarOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Mix Chart" }
                    },
                    Legend = new ChartOptionsLegend()
                    {
                        Position = ConstantPosition.TOP,
                    },
                    Tooltips = new ChartOptionsTooltip()
                    {
                        Mode = ConstantMode.INDEX,
                        Intersect = true
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
    }
}