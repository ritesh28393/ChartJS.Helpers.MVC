namespace ChartJS.Helpers.MVC
{
    public class ChartTypeDoughnut : IChartType
    {
        /// <summary>
        /// type of the chart
        /// </summary>
        public string Type { get; private set; } = ConstantType.DOUGHNUT;
        /// <summary>
        /// data and label of the chart
        /// </summary>
        public DoughnutData Data { get; set; }
        /// <summary>
        /// configure style of the chart
        /// </summary>
        public DoughnutOptions Options { get; set; }
    }
    public class DoughnutData : ChartData
    {
        /// <summary>
        /// represent data sets
        /// </summary>
        public DoughnutDataSets[] Datasets { get; set; }
    }
    public class DoughnutDataSets : ChartDataSets
    {
        /// <summary>
        /// The fill color of the arcs
        /// </summary>
        public string[] BackgroundColor { get; set; }
        /// <summary>
        /// The stroke width of the arcs in pixels
        /// </summary>
        public int[] BorderWidth { get; set; }
        /// <summary>
        /// The color of the arcs border.
        /// </summary>
        public string[] BorderColor { get; set; }
        /// <summary>
        /// The fill colour of the arcs when hovered.
        /// </summary>
        public string[] HoverBackgroundColor { get; set; }
        /// <summary>
        /// The stroke width of the arcs when hovered.
        /// </summary>
        public int[] HoverBorderWidth { get; set; }
        /// <summary>
        /// The stroke colour of the arcs when hovered.
        /// </summary>
        public string[] HoverBorderColor { get; set; }
    }
    public class DoughnutOptions : ChartOptions
    {
        /// <summary>
        /// The percentage(0-100) of the chart that is cut out of the middle.
        /// </summary>
        public int? CutoutPercentage { get; set; } = 50;
        /// <summary>
        /// Starting angle to draw arcs from.
        /// default value : -0.5 * System.Math.PI
        /// </summary>
        public double? Rotation { get; set; } = -0.5 * System.Math.PI;
        /// <summary>
        /// Sweep to allow arcs to cover
        /// default value : 2 * System.Math.PI
        /// </summary>
        public double? Circumference { get; set; } = 2 * System.Math.PI;
        /// <summary>
        /// When set, these options apply to all objects of that type unless specifically overridden by the configuration attached to a dataset
        /// </summary>
        public DoughnutElementsStyle Elements { get; set; }
    }
    public class DoughnutElementsStyle
    {
        /// <summary>
        /// Arcs are used in the polar area, doughnut and pie charts.
        /// </summary>
        public ChartOptionsElementsArc Arc { get; set; }
    }

}
