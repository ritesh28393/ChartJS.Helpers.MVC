using ChartJS.Helpers.MVC;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class LineChartsController : Controller
    {
        public ActionResult Basic()
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
                            Label = "My First dataset",
                            BorderColor = "green",
                            BorderWidth = 2,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new LineDataSets()
                        {
                            Label = "My Second dataset",
                            BorderColor = "blue",
                            BorderWidth = 2,
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Scales = new ChartOptionsScales()
                    {
                        XAxes = new ChartOptionsScalesAxes[] 
                        {
                            new ChartOptionsScalesAxes()
                            {
                                Display = true,
                                ScaleLabel = new ChartScaleLabel()
                                {
                                    Display = true,
                                    LabelString = "Month"
                                }
                            }
                        },
                        YAxes = new ChartOptionsScalesAxes[]
                        {
                            new ChartOptionsScalesAxes()
                            {
                                Display = true,
                                ScaleLabel = new ChartScaleLabel()
                                {
                                    Display = true,
                                    LabelString = "Value"
                                }
                            }
                        }
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Line Chart" }
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
                    Hover = new ChartOptionsHover()
                    {
                        Mode = ConstantMode.NEAREST,
                        Intersect = true
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
        public ActionResult MultiAxis()
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
                            Label = "My First dataset",
                            BorderColor = "green",
                            BackgroundColor = "green",
                            BFill = false,
                            BorderWidth = 2,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 },
                            YAxisID = "y-axis-1",
                        },
                        new LineDataSets()
                        {
                            Label = "My Second dataset",
                            BorderColor = "blue",
                            BackgroundColor = "blue",
                            BFill = false,
                            BorderWidth = 2,
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 },
                            YAxisID = "y-axis-2",
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Scales = new ChartOptionsScales()
                    {
                        XAxes = new ChartOptionsScalesAxes[]
                        {
                            new ChartOptionsScalesAxes()
                            {
                                Display = true,
                                ScaleLabel = new ChartScaleLabel()
                                {
                                    Display = true,
                                    LabelString = "Month"
                                }
                            }
                        },
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
                        Text = new string[] { "Chart.js Multi-Axis Line Chart" }
                    },
                    Legend = new ChartOptionsLegend()
                    {
                        Position = ConstantPosition.RIGHT,
                    },
                    Tooltips = new ChartOptionsTooltip()
                    {
                        Mode = ConstantMode.INDEX,
                        Intersect = false
                    },
                    Hover = new ChartOptionsHover()
                    {
                        Mode = ConstantMode.NEAREST,
                        Intersect = true
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
        public ActionResult Stepped()
        {
            ChartTypeLine NoStepInterpolation = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            Label = "Stepped Line : False",
                            BorderColor = "green",
                            BFill = false,
                            BSteppedLine = false,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "No Step Interpolation" }
                    }
                }
            };
            ChartTypeLine StepBeforeInterpolation1 = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            Label = "Stepped Line : true",
                            BorderColor = "blue",
                            BFill = false,
                            BSteppedLine = true,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Step Before Interpolation" }
                    }
                }
            };
            ChartTypeLine StepBeforeInterpolation2 = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            Label = "Stepped Line : Before",
                            BorderColor = "yellow",
                            BFill = false,
                            SSteppedLine = "before",
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Step Before Interpolation" }
                    }
                }
            };
            ChartTypeLine StepAfterInterpolation = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            Label = "Stepped Line : After",
                            BorderColor = "red",
                            BFill = false,
                            SSteppedLine = "after",
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Step After Interpolation" }
                    }
                }
            };

            ViewBag.NoStepInterpolationChart = new MvcHtmlString(NoStepInterpolation.Draw("myChart1"));
            ViewBag.StepBeforeInterpolation1Chart = new MvcHtmlString(StepBeforeInterpolation1.Draw("myChart2"));
            ViewBag.StepBeforeInterpolation2Chart = new MvcHtmlString(StepBeforeInterpolation2.Draw("myChart3"));
            ViewBag.StepAfterInterpolationChart = new MvcHtmlString(StepAfterInterpolation.Draw("myChart4"));
            return View();
        }
        public ActionResult Interpolation()
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
                            Label = "Cubic interpolation (monotone)",
                            BorderColor = "green",
                            BFill = false,
                            CubicInterpolationMode = "monotone",
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new LineDataSets()
                        {
                            Label = "Cubic interpolation (default)",
                            BorderColor = "blue",
                            BFill = false,
                            CubicInterpolationMode = "default",
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new LineDataSets()
                        {
                            Label = "Linear  interpolation",
                            BorderColor = "red",
                            BFill = false,
                            LineTension = 0,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Line Chart - Cubic interpolation mode" }
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
                    Hover = new ChartOptionsHover()
                    {
                        Mode = ConstantMode.NEAREST,
                        Intersect = true
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
        public ActionResult LineStyles()
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
                            Label = "Unfilled",
                            BorderColor = "blue",
                            BackgroundColor = "blue",
                            BFill = false,
                            LinearData = new int[]{ -63, -64, 34, 43, -56, 12, 70 }
                        },
                        new LineDataSets()
                        {
                            Label = "Filled",
                            BorderColor = "rgba(0, 255, 0, 0.3)",
                            BackgroundColor = "rgba(0, 255, 0, 0.3)",
                            BFill = true,
                            LinearData = new int[]{ 15, -54, 45, 24, -50, 43, 36 }
                        },
                        new LineDataSets()
                        {
                            Label = "Dashed",
                            BorderColor = "red",
                            BackgroundColor = "red",
                            BFill = false,
                            BorderDash = new int[]{ 5, 5},
                            LinearData = new int[]{ 6, 24, 40, -43, 56, 52, 7 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Chart.js Line Chart - Line Styles" }
                    },
                    Legend = new ChartOptionsLegend()
                    {
                        Position = ConstantPosition.RIGHT,
                    },
                    Tooltips = new ChartOptionsTooltip()
                    {
                        Mode = ConstantMode.INDEX,
                        Intersect = false
                    },
                    Hover = new ChartOptionsHover()
                    {
                        Mode = ConstantMode.NEAREST,
                        Intersect = true
                    }
                }
            };

            ViewBag.Chart = new MvcHtmlString(chart.Draw("myChart"));
            ViewBag.chartObj = chart;
            return View();
        }
        public ActionResult PointStyles()
        {
            ChartTypeLine Circle = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            BorderColor = "green",
                            BackgroundColor = "green",
                            BFill = false,
                            ShowLine = false,
                            PointStyle = ConstantPointStyle.CIRCLE,
                            PointRadius = 10,
                            PointHoverRadius = 15,
                            LinearData = new int[]{ 3, 64, 34, 43, 56, 12, 40 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Legend = new ChartOptionsLegend()
                    {
                        Display = false
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Point Style - Circle" }
                    }
                }
            };
            ChartTypeLine Cross = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            BorderColor = "red",
                            BackgroundColor = "red",
                            BFill = false,
                            ShowLine = false,
                            PointStyle = ConstantPointStyle.CROSS,
                            PointRadius = 10,
                            PointHoverRadius = 15,
                            LinearData = new int[]{ 3, 64, 34, 43, 56, 12, 40 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Legend = new ChartOptionsLegend()
                    {
                        Display = false
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Point Style - Cross" }
                    }
                }
            };
            ChartTypeLine CrossRot = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            BorderColor = "purple",
                            BackgroundColor = "purple",
                            BFill = false,
                            ShowLine = false,
                            PointStyle = ConstantPointStyle.CROSSROT,
                            PointRadius = 10,
                            PointHoverRadius = 15,
                            LinearData = new int[]{ 3, 64, 34, 43, 56, 12, 40 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Legend = new ChartOptionsLegend()
                    {
                        Display = false
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Point Style - CrossRot" }
                    }
                }
            };
            ChartTypeLine Dash = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            BorderColor = "pink",
                            BackgroundColor = "pink",
                            BFill = false,
                            ShowLine = false,
                            PointStyle = ConstantPointStyle.DASH,
                            PointRadius = 10,
                            PointHoverRadius = 15,
                            LinearData = new int[]{ 3, 64, 34, 43, 56, 12, 40 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Legend = new ChartOptionsLegend()
                    {
                        Display = false
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Point Style - Dash" }
                    }
                }
            };
            ChartTypeLine Line = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            BorderColor = "yellow",
                            BackgroundColor = "yellow",
                            BFill = false,
                            ShowLine = false,
                            PointStyle = ConstantPointStyle.LINE,
                            PointRadius = 10,
                            PointHoverRadius = 15,
                            LinearData = new int[]{ 3, 64, 34, 43, 56, 12, 40 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Legend = new ChartOptionsLegend()
                    {
                        Display = false
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Point Style - Line" }
                    }
                }
            };
            ChartTypeLine Rect = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            BorderColor = "black",
                            BackgroundColor = "black",
                            BFill = false,
                            ShowLine = false,
                            PointStyle = ConstantPointStyle.RECT,
                            PointRadius = 10,
                            PointHoverRadius = 15,
                            LinearData = new int[]{ 3, 64, 34, 43, 56, 12, 40 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Legend = new ChartOptionsLegend()
                    {
                        Display = false
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Point Style - Rect" }
                    }
                }
            };
            ChartTypeLine RectRot = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            BorderColor = "blue",
                            BackgroundColor = "blue",
                            BFill = false,
                            ShowLine = false,
                            PointStyle = ConstantPointStyle.RECTROT,
                            PointRadius = 10,
                            PointHoverRadius = 15,
                            LinearData = new int[]{ 3, 64, 34, 43, 56, 12, 40 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Legend = new ChartOptionsLegend()
                    {
                        Display = false
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Point Style - RectRot" }
                    }
                }
            };
            ChartTypeLine RectRounded = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            BorderColor = "orange",
                            BackgroundColor = "orange",
                            BFill = false,
                            ShowLine = false,
                            PointStyle = ConstantPointStyle.RECTROUNDED,
                            PointRadius = 10,
                            PointHoverRadius = 15,
                            LinearData = new int[]{ 3, 64, 34, 43, 56, 12, 40 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Legend = new ChartOptionsLegend()
                    {
                        Display = false
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Point Style - RectRounded" }
                    }
                }
            };
            ChartTypeLine Star = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            BorderColor = "gold",
                            BackgroundColor = "gold",
                            BFill = false,
                            ShowLine = false,
                            PointStyle = ConstantPointStyle.STAR,
                            PointRadius = 10,
                            PointHoverRadius = 15,
                            LinearData = new int[]{ 3, 64, 34, 43, 56, 12, 40 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Legend = new ChartOptionsLegend()
                    {
                        Display = false
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Point Style - Star" }
                    }
                }
            };
            ChartTypeLine Triangle = new ChartTypeLine()
            {
                Data = new LineData()
                {
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },
                    Datasets = new LineDataSets[]
                    {
                        new LineDataSets()
                        {
                            BorderColor = "green",
                            BackgroundColor = "green",
                            BFill = false,
                            ShowLine = false,
                            PointStyle = ConstantPointStyle.TRIANGLE,
                            PointRadius = 10,
                            PointHoverRadius = 15,
                            LinearData = new int[]{ 3, 64, 34, 43, 56, 12, 40 }
                        }
                    }
                },
                Options = new LineOptions()
                {
                    Legend = new ChartOptionsLegend()
                    {
                        Display = false
                    },
                    Title = new ChartOptionsTitle()
                    {
                        Display = true,
                        Text = new string[] { "Point Style - Triangle" }
                    }
                }
            };
            
            ViewBag.Circle = new MvcHtmlString(Circle.Draw("myChartCircle"));
            ViewBag.Cross = new MvcHtmlString(Cross.Draw("myChartCross"));
            ViewBag.CrossRot = new MvcHtmlString(CrossRot.Draw("myChartCrossRot"));
            ViewBag.Dash = new MvcHtmlString(Dash.Draw("myChartDash"));
            ViewBag.Line = new MvcHtmlString(Line.Draw("myChartLine"));
            ViewBag.Rect = new MvcHtmlString(Rect.Draw("myChartRect"));
            ViewBag.RectRot = new MvcHtmlString(RectRot.Draw("myChartRectRot"));
            ViewBag.RectRounded = new MvcHtmlString(RectRounded.Draw("myChartRectRounded"));
            ViewBag.Star = new MvcHtmlString(Star.Draw("myChartStar"));
            ViewBag.Triangle = new MvcHtmlString(Triangle.Draw("myChartTriangle"));
            return View();
        }
    }
}