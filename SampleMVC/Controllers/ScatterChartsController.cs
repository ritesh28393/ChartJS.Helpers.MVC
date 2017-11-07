using ChartJS.Helpers.MVC;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class ScatterChartsController : Controller
    {
        public ActionResult Basic()
        {
            ChartTypeScatter chart = new ChartTypeScatter()
            {
                Data = new ScatterData()
                {
                    Datasets = new ScatterDataSets[]
                    {
                        new ScatterDataSets()
                        {
                            Label = "My First dataset",
                            BorderColor = "green",
                            BorderWidth = 2,
                            XYData = new XYdataItem[]
                            {
                                new XYdataItem(){ X=12, Y=12 },
                                new XYdataItem(){ X=2, Y=45 },
                                new XYdataItem(){ X=21, Y=78 },
                                new XYdataItem(){ X=64, Y=59 },
                                new XYdataItem(){ X=54, Y=25 },
                                new XYdataItem(){ X=78, Y=88 },
                            }
                        },
                        new ScatterDataSets()
                        {
                            Label = "My Second dataset",
                            BorderColor = "blue",
                            BorderWidth = 2,
                            XYData = new XYdataItem[]
                            {
                                new XYdataItem(){ X=52, Y=12 },
                                new XYdataItem(){ X=2, Y=12 },
                                new XYdataItem(){ X=10, Y=55 },
                                new XYdataItem(){ X=45, Y=87 },
                                new XYdataItem(){ X=77, Y=95 },
                                new XYdataItem(){ X=5, Y=12 },
                            }
                        }
                    }
                },
                Options = new ScatterOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Scatter Chart" }
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
        public ActionResult MultiAxis()
        {
            ChartTypeScatter chart = new ChartTypeScatter()
            {
                Data = new ScatterData()
                {
                    Datasets = new ScatterDataSets[]
                    {
                        new ScatterDataSets()
                        {
                            Label = "My First dataset",
                            BorderColor = "green",
                            BackgroundColor = "green",
                            BorderWidth = 2,
                            XYData = new XYdataItem[]
                            {
                                new XYdataItem(){ X=12, Y=12 },
                                new XYdataItem(){ X=2, Y=45 },
                                new XYdataItem(){ X=21, Y=78 },
                                new XYdataItem(){ X=64, Y=59 },
                                new XYdataItem(){ X=54, Y=25 },
                                new XYdataItem(){ X=78, Y=88 },
                            },
                            YAxisID = "y-axis-1",
                        },
                        new ScatterDataSets()
                        {
                            Label = "My Second dataset",
                            BorderColor = "blue",
                            BackgroundColor = "blue",
                            BorderWidth = 2,
                            XYData = new XYdataItem[]
                            {
                                new XYdataItem(){ X=52, Y=12 },
                                new XYdataItem(){ X=2, Y=12 },
                                new XYdataItem(){ X=10, Y=55 },
                                new XYdataItem(){ X=45, Y=87 },
                                new XYdataItem(){ X=77, Y=95 },
                                new XYdataItem(){ X=5, Y=12 },
                            },
                            YAxisID = "y-axis-2",
                        }
                    }
                },
                Options = new ScatterOptions()
                {
                    Scales = new ChartOptionsScales()
                    {
                        YAxes = new ChartOptionsScalesAxes[]
                        {
                            new ChartOptionsScalesAxes()
                            {
                                Display = true,
                                Position = ConstantPosition.LEFT,
                                Id = "y-axis-1",
                            },
                            new ChartOptionsScalesAxes()
                            {
                                Display = true,
                                Position = ConstantPosition.RIGHT,
                                Id = "y-axis-2",
                                GridLines = new ChartOptionsScaleGridLines(){ DrawOnChartArea = false}
                            }
                        }
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Multi-Axis Scatter Chart" }
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
    }
}