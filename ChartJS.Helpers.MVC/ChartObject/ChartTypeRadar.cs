namespace ChartJS.Helpers.MVC
{
    public class ChartTypeRadar : IChartType
    {
        /// <summary>
        /// type of the chart
        /// </summary>
        public string Type { get; private set; } = ConstantType.RADAR;
        /// <summary>
        /// data and label of the chart
        /// </summary>
        public RadarData Data { get; set; }
        /// <summary>
        /// configure style of the chart
        /// </summary>
        public RadarOptions Options { get; set; }
    }
    public class RadarData : ChartData
    {
        /// <summary>
        /// represent data sets
        /// </summary>
        public RadarDataSets[] Datasets { get; set; }
    }
    public class RadarDataSets : ChartDataSets
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
    }
    public class RadarOptions : ChartOptions
    {

    }
}
