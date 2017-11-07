namespace ChartJS.Helpers.MVC
{
    public class ChartTypeBubble : IChartType
    {
        /// <summary>
        /// type of the chart
        /// </summary>
        public string Type { get; private set; } = ConstantType.BUBBLE;
        /// <summary>
        /// data and label of the chart
        /// </summary>
        public BubbleData Data { get; set; }
        /// <summary>
        /// configure style of the chart
        /// </summary>
        public BubbleOptions Options { get; set; }
    }
    public class BubbleData : ChartData
    {
        /// <summary>
        /// represent data sets
        /// </summary>
        public BubbleDataSets[] Datasets { get; set; }
    }
    public class BubbleDataSets : ChartDataSets
    {
        /// <summary>
        /// The fill color of the bubbles
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// The width of the bubbles in pixels.
        /// </summary>
        public int? BorderWidth { get; set; }
        /// <summary>
        /// The color of the bubbles
        /// </summary>
        public string BorderColor { get; set; }
        /// <summary>
        /// bubble radius (in pixels)
        /// </summary>
        public int? Radius { get; set; } = 3;
        /// <summary>
        /// bubble shape style
        /// </summary>
        public string PointStyle { get; set; } = ConstantPointStyle.CIRCLE;
        /// <summary>
        /// bubble's background color when hovered.
        /// </summary>
        public string HoverBackgroundColor { get; set; }
        /// <summary>
        /// bubble's border width when hovered
        /// </summary>
        public int? HoverBorderWidth { get; set; } = 1;
        /// <summary>
        /// bubble's border color when hovered
        /// </summary>
        public string HoverBorderColor { get; set; }
        /// <summary>
        /// bubble additional radius for hit detection (in pixels)
        /// </summary>
        public int? HitRadius { get; set; } = 1;
        /// <summary>
        /// bubble additional radius when hovered (in pixels)
        /// </summary>
        public int? HoverRadius { get; set; } = 4;
    }
    public class BubbleOptions : ChartOptions
    {
        /// <summary>
        /// When set, these options apply to all objects of that type unless specifically overridden by the configuration attached to a dataset
        /// </summary>
        public BubbleElementsStyle Elements { get; set; }
    }
    public class BubbleElementsStyle
    {
        /// <summary>
        /// Point elements are used to represent the points in a line chart or a bubble chart.
        /// </summary>
        public ChartOptionsElementsPoint Point { get; set; }
    }

}
