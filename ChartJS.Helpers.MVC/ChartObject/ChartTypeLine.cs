namespace ChartJS.Helpers.MVC
{
    public class ChartTypeLine : IChartType
    {
        /// <summary>
        /// type of the chart
        /// </summary>
        public string Type { get; private set; } = ConstantType.LINE;
        /// <summary>
        /// data and label of the chart
        /// </summary>
        public LineData Data { get; set; }
        /// <summary>
        /// configure style of the chart
        /// </summary>
        public LineOptions Options { get; set; }
    }
    public class LineData : ChartData
    {
        /// <summary>
        /// represent data sets
        /// </summary>
        public LineDataSets[] Datasets { get; set; }
    }
    public class LineDataSets : ChartDataSets
    {

        /// <summary>
        /// Bézier curve tension(0 for no Bézier curves). Set to 0 to draw straightlines. This option is ignored if monotone cubic interpolation is used.
        /// </summary>
        public double? LineTension { get; set; }
        /// <summary>
        /// The fill color under the line
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// The width of the line in pixels.
        /// </summary>
        public int? BorderWidth { get; set; }
        /// <summary>
        /// The color of the line
        /// </summary>
        public string BorderColor { get; set; }
        /// <summary>
        /// Cap style of the line
        /// </summary>
        public string BorderCapStyle { get; set; }
        /// <summary>
        /// Length and spacing of dashes
        /// </summary>
        public int[] BorderDash { get; set; }
        /// <summary>
        /// Offset for line dashes
        /// </summary>
        public int? BorderDashOffset { get; set; }
        /// <summary>
        /// Line join style
        /// </summary>
        public string BorderJoinStyle { get; set; }
        /// <summary>
        /// Algorithm used to interpolate a smooth curve from the discrete data points.
        /// Two types of interpolation modes are supported:'default' and 'monotone'.
        /// The 'default' algorithm uses a custom weighted cubic interpolation, which produces pleasant curves for all types of datasets.
        /// The 'monotone' algorithm is more suited to y = f(x) datasets : it preserves monotonicity
        /// </summary>
        public string CubicInterpolationMode { get; set; }
        /// <summary>
        /// How to fill the area under the line.
        /// Relative dataset index - acceptable values like '-1', '-2', '+1', ...
        /// Boundary - acceptable values are 'start', 'end', 'origin'
        /// </summary>
        public string SFill { get; set; }
        /// <summary>
        /// How to fill the area under the line.
        /// Absolute dataset index - acceptable values like 1, 2, 3, ...
        /// </summary>
        public int? IFill { get; set; }
        /// <summary>
        /// How to fill the area under the line.
        /// Disabled - false
        /// </summary>
        public bool? BFill { get; set; }
        /// <summary>
        /// The radius of the point shape. If set to 0, the point is not rendered
        /// </summary>
        public int? PointRadius { get; set; }
        /// <summary>
        /// Point style
        /// </summary>
        public string PointStyle { get; set; }
        /// <summary>
        /// Points fill color
        /// </summary>
        public string PointBackgroundColor { get; set; }
        /// <summary>
        /// The width of the point border in pixels
        /// </summary>
        public int? PointBorderWidth { get; set; }
        /// <summary>
        /// Point stroke color
        /// </summary>
        public string PointBorderColor { get; set; }
        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        public string PointHoverBackgroundColor { get; set; }
        /// <summary>
        /// Point border width when hovered
        /// </summary>
        public int? PointHoverBorderWidth { get; set; }
        /// <summary>
        /// Point border color when hovered
        /// </summary>
        public string PointHoverBorderColor { get; set; }
        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events.
        /// </summary>
        public int? PointHitRadius { get; set; }
        /// <summary>
        /// The radius of the point when hovered.
        /// </summary>
        public int? PointHoverRadius { get; set; }
        /// <summary>
        /// If false, the line is not drawn for this dataset.
        /// </summary>
        public bool? ShowLine { get; set; }
        /// <summary>
        /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line
        /// </summary>
        public bool? spanGaps { get; set; }
        /// <summary>
        /// true to show the line as a stepped line(tension will be ignored).
        /// false: No Step Interpolation (default)
        /// true: Step-before Interpolation(eq. 'before')
        /// </summary>
        public bool? BSteppedLine { get; set; }
        /// <summary>
        /// The following values are supported for steppedLine:
        /// 'before': Step-before Interpolation
        /// 'after': Step-after Interpolation
        /// </summary>
        public string SSteppedLine { get; set; }
    }
    public class LineOptions : ChartOptions
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
        public LineElementsStyle Elements { get; set; }
    }
    public class LineElementsStyle
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
