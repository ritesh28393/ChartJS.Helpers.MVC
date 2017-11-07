using ChartJS.Helpers.MVC;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class BarChartsController : Controller
    {
        public ActionResult Vertical()
        {
            ChartTypeBar chart = new ChartTypeBar()
            {
                Data = new BarData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new BarDataSets[]
                    {
                        new BarDataSets()
                        {
                            Label = "Dataset 1",
                            BackgroundColor = "green",
                            BorderColor = "green",
                            BorderWidth = 1,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new BarDataSets()
                        {
                            Label = "Dataset 2",
                            BackgroundColor = "blue",
                            BorderColor = "blue",
                            BorderWidth = 1,
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 }
                        }
                    }
                },
                Options = new BarOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Bar Chart" }
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
        public ActionResult Horizontal()
        {
            ChartTypeHorizontalBar chart = new ChartTypeHorizontalBar()
            {
                Data = new BarData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new BarDataSets[]
                    {
                        new BarDataSets()
                        {
                            Label = "Dataset 1",
                            BackgroundColor = "green",
                            BorderColor = "green",
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new BarDataSets()
                        {
                            Label = "Dataset 2",
                            BackgroundColor = "blue",
                            BorderColor = "blue",
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 }
                        }
                    }
                },
                Options = new BarOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Horizontal Bar Chart" }
                    },
                    Legend = new ChartOptionsLegend()
                    {
                        Position = ConstantPosition.RIGHT,
                    },
                    Elements = new BarElementsStyle()
                    {
                        Rectngle = new ChartOptionsElementsRectngle()
                        {
                            BorderWidth = 2
                        }
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
        public ActionResult MultiAxis()
        {
            ChartTypeBar chart = new ChartTypeBar()
            {
                Data = new BarData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new BarDataSets[]
                    {
                        new BarDataSets()
                        {
                            Label = "Dataset 1",
                            BackgroundColor = "green",
                            BorderColor = "green",
                            BorderWidth = 1,
                            YAxisID = "y-axis-1",
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new BarDataSets()
                        {
                            Label = "Dataset 2",
                            BackgroundColor = "blue",
                            BorderColor = "blue",
                            BorderWidth = 1,
                            YAxisID = "y-axis-2",
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 }
                        }
                    }
                },
                Options = new BarOptions()
                {
                    Scales = new ChartOptionsScales()
                    {
                        YAxes = new ChartOptionsScalesAxes[] 
                        {
                            new ChartOptionsScalesAxes()
                            {
                                Display = true,
                                Position = ConstantPosition.LEFT,
                                Id = "y-axis-1"
                            },
                            new ChartOptionsScalesAxes()
                            {
                                Display = true,
                                Position = ConstantPosition.RIGHT,
                                Id = "y-axis-2",
                                GridLines = new ChartOptionsScaleGridLines()
                                {
                                    DrawOnChartArea = false
                                }
                            }
                        }
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Bar Chart - Multi Axis" }
                    },
                    Tooltips = new ChartOptionsTooltip()
                    {
                        Mode = ConstantMode.INDEX,
                        Intersect = true
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
        public ActionResult Stacked()
        {
            ChartTypeBar chart = new ChartTypeBar()
            {
                Data = new BarData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new BarDataSets[]
                    {
                        new BarDataSets()
                        {
                            Label = "Dataset 1",
                            BackgroundColor = "green",
                            BorderColor = "green",
                            BorderWidth = 1,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new BarDataSets()
                        {
                            Label = "Dataset 2",
                            BackgroundColor = "blue",
                            BorderColor = "blue",
                            BorderWidth = 1,
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 }
                        },
                        new BarDataSets()
                        {
                            Label = "Dataset 3",
                            BackgroundColor = "yellow",
                            BorderColor = "yellow",
                            BorderWidth = 1,
                            LinearData = new int[]{ 10, 23, 45, -12, 48, -32, -25 }
                        }
                    }
                },
                Options = new BarOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Bar Chart - Stacked" }
                    },
                    Legend = new ChartOptionsLegend()
                    {
                        Position = ConstantPosition.TOP,
                    },
                    Tooltips = new ChartOptionsTooltip()
                    {
                        Mode = ConstantMode.INDEX,
                        Intersect = false
                    },
                    Scales = new ChartOptionsScales()
                    {
                        XAxes = new ChartOptionsScalesAxes[] { new ChartOptionsScalesAxes() { Stacked = true } },
                        YAxes = new ChartOptionsScalesAxes[] { new ChartOptionsScalesAxes() { Stacked = true } }
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
        public ActionResult StackedGroup()
        {
            ChartTypeBar chart = new ChartTypeBar()
            {
                Data = new BarData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new BarDataSets[]
                    {
                        new BarDataSets()
                        {
                            Label = "Dataset 1",
                            BackgroundColor = "green",
                            BorderColor = "green",
                            BorderWidth = 1,
                            Stack = "stack 1",
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new BarDataSets()
                        {
                            Label = "Dataset 2",
                            BackgroundColor = "blue",
                            BorderColor = "blue",
                            BorderWidth = 1,
                            Stack = "stack 1",
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 }
                        },
                        new BarDataSets()
                        {
                            Label = "Dataset 3",
                            BackgroundColor = "yellow",
                            BorderColor = "yellow",
                            BorderWidth = 1,
                            Stack = "stack 2",
                            LinearData = new int[]{ 10, 23, 45, -12, 48, -32, -25 }
                        }
                    }
                },
                Options = new BarOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Bar Chart - Stacked" }
                    },
                    Legend = new ChartOptionsLegend()
                    {
                        Position = ConstantPosition.TOP,
                    },
                    Tooltips = new ChartOptionsTooltip()
                    {
                        Mode = ConstantMode.INDEX,
                        Intersect = false
                    },
                    Scales = new ChartOptionsScales()
                    {
                        XAxes = new ChartOptionsScalesAxes[] { new ChartOptionsScalesAxes() { Stacked = true } },
                        YAxes = new ChartOptionsScalesAxes[] { new ChartOptionsScalesAxes() { Stacked = true } }
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
    }
}