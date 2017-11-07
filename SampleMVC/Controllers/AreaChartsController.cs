using ChartJS.Helpers.MVC;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class AreaChartsController : Controller
    {
        public ActionResult LineBoundaries()
        {
            ChartTypeLine FillFalse = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            Label = "My dataset",
                            BorderColor = "green",
                            BackgroundColor = "rgba(0,255,0,0.5)",
                            BorderWidth = 2,
                            BFill = false,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Fill : False" }
                    }
                }
            };
            ChartTypeLine FillOrigin = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            Label = "My dataset",
                            BorderColor = "green",
                            BackgroundColor = "rgba(0,255,0,0.5)",
                            BorderWidth = 2,
                            SFill = "origin",
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Fill : Origin" }
                    }
                }
            };
            ChartTypeLine FillStart = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            Label = "My dataset",
                            BorderColor = "green",
                            BackgroundColor = "rgba(0,255,0,0.5)",
                            BorderWidth = 2,
                            SFill = "start",
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Fill : Start" }
                    }
                }
            };
            ChartTypeLine FillEnd = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            Label = "My dataset",
                            BorderColor = "green",
                            BackgroundColor = "rgba(0,255,0,0.5)",
                            BorderWidth = 2,
                            SFill = "end",
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Fill : End" }
                    }
                }
            };

            ViewBag.FillFalse = new MvcHtmlString(FillFalse.Draw("myChartFillFalse"));
            ViewBag.FillOrigin = new MvcHtmlString(FillOrigin.Draw("myChartFillOrigin"));
            ViewBag.FillStart = new MvcHtmlString(FillStart.Draw("myChartFillStart"));
            ViewBag.FillEnd = new MvcHtmlString(FillEnd.Draw("myChartFillEnd"));
            return View();
        }
        public ActionResult LineStacked()
        {
            ChartTypeLine chart = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            Label = "Dataset 1",
                            BackgroundColor = "rgba(0, 0, 255, 0.5)",
                            BorderColor = "green",
                            BorderWidth = 1,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new LineDataSets()
                        {
                            Label = "Dataset 2",
                            BackgroundColor = "rgba(0, 255, 0, 0.5)",
                            BorderColor = "blue",
                            BorderWidth = 1,
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 }
                        },
                        new LineDataSets()
                        {
                            Label = "Dataset 3",
                            BackgroundColor = "rgba(255, 0, 0, 0.5)",
                            BorderColor = "red",
                            BorderWidth = 1,
                            LinearData = new int[]{ 10, 23, 45, -12, 48, -32, -25 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Line Chart - Stacked" }
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