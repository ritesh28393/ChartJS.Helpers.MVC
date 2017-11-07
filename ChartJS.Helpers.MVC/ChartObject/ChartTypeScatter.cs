namespace ChartJS.Helpers.MVC
{
    public class ChartTypeScatter : IChartType
    {
        /// <summary>
        /// type of the chart
        /// </summary>
        public string Type { get; private set; } = ConstantType.SCATTER;
        /// <summary>
        /// data and label of the chart
        /// </summary>
        public ScatterData Data { get; set; }
        /// <summary>
        /// configure style of the chart
        /// </summary>
        public ScatterOptions Options { get; set; }
    }
    public class ScatterData : ChartData
    {
        /// <summary>
        /// represent data sets
        /// </summary>
        public ScatterDataSets[] Datasets { get; set; }
    }
    public class ScatterDataSets : LineDataSets
    {

    }
    public class ScatterOptions : ChartOptions
    {
        /// <summary>
        /// If false, the lines between points are not drawn.
        /// </summary>
        public bool? ShowLines { get; set; }
        /// <summary>
        /// If false, NaN data causes a break in the line.
        /// </summary>
        public bool? SpanGaps { get; set; }
        /// <summary>
        /// When set, these options apply to all objects of that type unless specifically overridden by the configuration attached to a dataset
        /// </summary>
        public ScatterElementsStyle Elements { get; set; }
    }
    public class ScatterElementsStyle
    {
        /// <summary>
        /// Point elements are used to represent the points in a line chart or a bubble chart.
        /// </summary>
        public ChartOptionsElementsPoint Point { get; set; }
        /// <summary>
        /// Line elements are used to represent the line in a line chart.
        /// </summary>
        public ChartOptionsElementsLine Line { get; set; }
    }

}
