namespace ChartJS.Helpers.MVC
{
    public class ChartTypeBar : IChartType
    {
        /// <summary>
        /// type of the chart
        /// </summary>
        public string Type { get; private set; } = ConstantType.BAR;
        /// <summary>
        /// data and label of the chart
        /// </summary>
        public BarData Data { get; set; }
        /// <summary>
        /// configure style of the chart
        /// </summary>
        public BarOptions Options { get; set; }
    }
    public class BarData : ChartData
    {
        /// <summary>
        /// represent data sets
        /// </summary>
        public BarDataSets[] Datasets { get; set; }
    }
    public class BarDataSets : ChartDataSets
    {
        /// <summary>
        /// The fill color of the bar
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// The stroke width of the bar in pixels
        /// </summary>
        public int? BorderWidth { get; set; }
        /// <summary>
        /// The color of the bar border.
        /// </summary>
        public string BorderColor { get; set; }
        /// <summary>
        /// Which edge to skip drawing the border for.
        /// Options are: 'bottom', 'left', 'top' and 'right'
        /// </summary>
        public string BorderSkipped { get; set; }
        /// <summary>
        /// The fill colour of the bars when hovered.
        /// </summary>
        public string HoverBackgroundColor { get; set; }
        /// <summary>
        /// The stroke width of the bars when hovered.
        /// </summary>
        public int? HoverBorderWidth { get; set; }
        /// <summary>
        /// The stroke colour of the bars when hovered.
        /// </summary>
        public string HoverBorderColor { get; set; }
        /// <summary>
        /// The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack)
        /// </summary>
        public string Stack { get; set; }
    }
    public class BarOptions : ChartOptions
    {
        /// <summary>
        /// Percent (0-1) of the available width each bar should be within the category width. 1.0 will take the whole category width and put the bars right next to each other.
        /// </summary>
        public double? BarPercentage { get; set; } = 0.9;
        /// <summary>
        /// Percent (0-1) of the available width each category should be within the sample width. 
        /// </summary>
        public double? CategoryPercentage { get; set; } = 0.8;
        /// <summary>
        /// Manually set width of each bar in pixels. If not set, the base sample widths are calculated automatically so that they take the full available widths without overlap. Then, the bars are sized using barPercentage and categoryPercentage.
        /// </summary>
        public int? BarThickness { get; set; }
        /// <summary>
        /// Set this to ensure that bars are not sized thicker than this.
        /// </summary>
        public int? MaxBarThickness { get; set; }
        /// <summary>
        /// When set, these options apply to all objects of that type unless specifically overridden by the configuration attached to a dataset
        /// </summary>
        public BarElementsStyle Elements { get; set; }
    }
    public class BarElementsStyle
    {
        /// <summary>
        /// Rectangle elements are used to represent the bars in a bar chart.
        /// </summary>
        public ChartOptionsElementsRectngle Rectngle { get; set; }
    }

}
