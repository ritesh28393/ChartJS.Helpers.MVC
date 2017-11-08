# ChartJS.Helpers.MVC <img src="https://raw.githubusercontent.com/ritesh28393/ChartJS.Helpers.MVC/master/chartjs.png" alt="chartjs" style="width: 40px; height: 40px; vertical-align: bottom;"/>

[![nuget](https://img.shields.io/badge/nuget-V3.1.1-brightgreen.svg?style=flat-square&maxAge=3600)](https://www.nuget.org/packages/ChartJS.Helpers.MVC)

Wrapper to generate charts using the popular latest Chart.Js library (http://www.chartjs.org). It also provides Asp.Net MVC HtmlHelper extension method for generating charts.

*Samples for all types of chart can be found at https://github.com/ritesh28393/ChartJS.Helpers.MVC/tree/master/SampleMVC*

## Basic Line chart

```C#
ChartTypeLine LineChart = new ChartTypeLine()
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
            ViewBag.LineChart = new MvcHtmlString(chart.Draw("myLineChart"));
```

## Vertical Bar chart

```C#
ChartTypeBar VerticalBarChart = new ChartTypeBar()
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

            ViewBag.VerticalBarChart = new MvcHtmlString(chart.Draw("myVerticalBarChart"));
```

## Pie chart

```C#
ChartTypePie PieChart = new ChartTypePie()
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

            ViewBag.PieChart = new MvcHtmlString(chart.Draw("myPieChart"));
 ```

## Doughnut chart 

```C#           
ChartTypeDoughnut DoughnutChart = new ChartTypeDoughnut()
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

            ViewBag.DoughnutChart = new MvcHtmlString(chart.Draw("myDoughnutChart"));
```

## Polar Area chart 

```C#            
ChartTypePolarArea PolarAreaChart = new ChartTypePolarArea()
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

            ViewBag.PolarAreaChart = new MvcHtmlString(chart.Draw("myPolarAreaChart"));
```

## Scatter chart 

```C#            
ChartTypeScatter ScatterChart = new ChartTypeScatter()
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

            ViewBag.ScatterChart = new MvcHtmlString(chart.Draw("myScatterChart"));
```

## Mix(line and bar) chart 

```C#
ChartTypeMix MixChart = new ChartTypeMix()
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

            ViewBag.MixChart = new MvcHtmlString(chart.Draw("myMixChart"));
