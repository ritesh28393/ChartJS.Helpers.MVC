namespace ChartJS.Helpers.MVC
{
    public class ChartOptionsElementsLine
    {
        /// <summary>
        /// Bézier curve tension(0 for no Bézier curves). Set to 0 to draw straightlines. This option is ignored if monotone cubic interpolation is used.
        /// </summary>
        public double? Tension { get; set; } = 0.4;
        /// <summary>
        /// Line fill color
        /// </summary>
        public string BackgroundColor { get; set; } = "rgba(0,0,0,0.1)";
        /// <summary>
        /// Line stroke width.
        /// </summary>
        public int? BorderWidth { get; set; } = 3;
        /// <summary>
        /// Line stroke color
        /// </summary>
        public string BorderColor { get; set; } = "rgba(0,0,0,0.1)";
        /// <summary>
        /// Line cap style
        /// </summary>
        public string BorderCapStyle { get; set; } = "butt";
        /// <summary>
        /// Line dash
        /// </summary>
        public int[] BorderDash { get; set; }
        /// <summary>
        /// Line dash offset
        /// </summary>
        public int? BorderDashOffset { get; set; } = 0;
        /// <summary>
        /// Line join style
        /// </summary>
        public string BorderJoinStyle { get; set; } = "miter";
        /// <summary>
        /// true to keep Bézier control inside the chart, false for no restriction.
        /// </summary>
        public bool? CapBezierPoints { get; set; } = true;
        /// <summary>
        /// Algorithm used to interpolate a smooth curve from the discrete data points.
        /// Two types of interpolation modes are supported:'default' and 'monotone'.
        /// The 'default' algorithm uses a custom weighted cubic interpolation, which produces pleasant curves for all types of datasets.
        /// The 'monotone' algorithm is more suited to y = f(x) datasets : it preserves monotonicity
        /// </summary>
        public string CubicInterpolationMode { get; set; }
        /// <summary>
        /// How to fill the area under the line.
        /// Fill location: 'zero', 'top', 'bottom' or 'no fill'
        /// </summary>
        public string Fill { get; set; }
        /// <summary>
        /// true to show the line as a stepped line(tension will be ignored).
        /// </summary>
        public bool? Stepped { get; set; } = false;
    }
}