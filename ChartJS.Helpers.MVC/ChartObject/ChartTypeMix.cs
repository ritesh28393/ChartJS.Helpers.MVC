namespace ChartJS.Helpers.MVC
{
    public class ChartTypeMix : IChartType
    {
        /// <summary>
        /// type of the chart
        /// </summary>
        public string Type { get; private set; } = ConstantType.BAR;
        /// <summary>
        /// data and label of the chart
        /// </summary>
        public MixData Data { get; set; }
        /// <summary>
        /// configure style of the chart
        /// </summary>
        public BarOptions Options { get; set; }
    }
    public class MixData : ChartData
    {
        /// <summary>
        /// represent data sets
        /// </summary>
        public MixDataSets[] Datasets { get; set; }
    }
    public class MixDataSets : ChartDataSets
    {
        /// <summary>
        /// Unless using line in same chart - mark this 'type' as 'line' - don't use this property
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The fill color of the bar, or
        /// (if type is 'line') The fill color under the line
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// The stroke width of the bar in pixels
        /// (if type is 'line') The width of the line in pixels.
        /// </summary>
        public int? BorderWidth { get; set; }
        /// <summary>
        /// The color of the bar border.
        /// (if type is 'line') The color of the line
        /// </summary>
        public string BorderColor { get; set; }
    }
}
