using ChartJS.Helpers.MVC;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class ArcChartsController : Controller
    {
        public ActionResult PieBasic()
        {
            ChartTypePie chart = new ChartTypePie()
            {
                Data = new PieData()
                {
                    Labels = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                    Datasets = new PieDataSets[]
                    {
                        new PieDataSets()
                        {
                            Label = "My First dataset",
                            BackgroundColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            BorderColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            HoverBackgroundColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            HoverBorderColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            LinearData = new int[]{ 63, 64, 34, 43, 12 }
                        }
                    }
                },
                Options = new PieOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Pie Chart" }
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
        public ActionResult DoughnutBasic()
        {
            ChartTypeDoughnut chart = new ChartTypeDoughnut()
            {
                Data = new DoughnutData()
                {
                    Labels = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                    Datasets = new DoughnutDataSets[]
                    {
                        new DoughnutDataSets()
                        {
                            Label = "My First dataset",
                            BackgroundColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            BorderColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            HoverBackgroundColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            HoverBorderColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            LinearData = new int[]{ 63, 64, 34, 43, 12 }
                        }
                    }
                },
                Options = new DoughnutOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Doughnut Chart" }
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
        public ActionResult PolarAreaBasic()
        {
            ChartTypePolarArea chart = new ChartTypePolarArea()
            {
                Data = new PolarAreaData()
                {
                    Labels = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                    Datasets = new PolarAreaDataSets[]
                    {
                        new PolarAreaDataSets()
                        {
                            Label = "My First dataset",
                            BackgroundColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            BorderColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            HoverBackgroundColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            HoverBorderColor = new string[] { "Red", "Orange", "Yellow", "Green", "Blue" },
                            HoverBorderWidth = new int[] { 3, 3, 3, 3, 3},
                            LinearData = new int[]{ 63, 11, 34, 43, 12 }
                        }
                    }
                },
                Options = new PolarAreaOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Polar Area Chart" }
                    },
                    Scale = new ChartOptionsScale()
                    {
                        Ticks = new ChartOptionsScaleTicks() { BeginAtZero = true}
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
    }
}