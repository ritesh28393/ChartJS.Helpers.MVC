namespace ChartJS.Helpers.MVC
{
    public class ChartOptionsScale
    {
        /// <summary>
        /// Angle line configuration
        /// </summary>
        public ChartOptionsScaleAngleLines angleLines { get; set; } = new ChartOptionsScaleAngleLines();
        /// <summary>
        /// Grid line configuration
        /// </summary>
        public ChartOptionsScaleGridLines GridLines { get; set; } = new ChartOptionsScaleGridLines();
        /// <summary>
        /// Point label configuration
        /// </summary>
        public ChartOptionsScalePointLabels PointLabels { get; set; } = new ChartOptionsScalePointLabels();
        /// <summary>
        /// Tick configuration
        /// </summary>
        public ChartOptionsScaleTicks Ticks { get; set; } = new ChartOptionsScaleTicks();
    }
    public class ChartOptionsScaleAngleLines
    {
        /// <summary>
        /// if true, angle lines are shown
        /// </summary>
        public bool? Display { get; set; }
        /// <summary>
        /// Color of angled lines
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Width of angled lines
        /// </summary>
        public int? LineWidth { get; set; }
    }
    public class ChartOptionsScaleGridLines
    {
        /// <summary>
        /// If false, do not display grid lines for this axis.
        /// </summary>
        public bool? Display { get; set; }
        /// <summary>
        /// The first color applies to the first grid line, the second to the second grid line and so on.
        /// If only value is passed, then it is applied to all grid lines
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Length and spacing of dashes on grid lines
        /// </summary>
        public int[] BorderDash { get; set; }
        /// <summary>
        /// Offset for line dashes
        /// </summary>
        public int? BorderDashOffset { get; set; }
        /// <summary>
        /// Stroke width of grid lines
        /// </summary>
        public int[] LineWidth { get; set; }
        /// <summary>
        /// If true, draw border at the edge between the axis and the chart area.
        /// </summary>
        public bool? DrawBorder { get; set; }
        /// <summary>
        /// If true, draw lines on the chart area inside the axis lines. This is useful when there are multiple axes and you need to control which grid lines are drawn.
        /// </summary>
        public bool? DrawOnChartArea { get; set; }
        /// <summary>
        /// If true, draw lines beside the ticks in the axis area beside the chart.
        /// </summary>
        public bool? DrawTicks { get; set; }
        /// <summary>
        /// Length in pixels that the grid lines will draw into the axis area.
        /// </summary>
        public int? TickMarkLength { get; set; }
        /// <summary>
        /// Stroke width of the grid line for the first index (index 0).
        /// </summary>
        public int? ZeroLineWidth { get; set; }
        /// <summary>
        /// Stroke color of the grid line for the first index (index 0).
        /// </summary>
        public string ZeroLineColor { get; set; }
        /// <summary>
        /// Length and spacing of dashes of the grid line for the first index (index 0)
        /// </summary>
        public int[] ZeroLineBorderDash { get; set; }
        /// <summary>
        /// Offset for line dashes of the grid line for the first index (index 0).
        /// </summary>
        public int? ZeroLineBorderDashOffset { get; set; }
        /// <summary>
        /// If true, grid lines will be shifted to be between labels. This is set to true in the bar chart by default.
        /// </summary>
        public bool? offsetGridLines { get; set; }
    }
    public class ChartOptionsScalePointLabels : ChartLabel
    {

    }
    public class ChartOptionsScaleTicks : ChartLabel
    {
        /// <summary>
        /// If true, show tick marks
        /// </summary>
        public bool? Display { get; set; }
        /// <summary>
        /// Reverses order of tick labels.
        /// </summary>
        public bool? Reverse { get; set; }
        /// <summary>
        /// If true, draw a background behind the tick labels
        /// </summary>
        public bool? ShowLabelBackdrop { get; set; }
        /// <summary>
        /// Color of label backdrops
        /// </summary>
        public string BackdropColor { get; set; }
        /// <summary>
        /// Horizontal padding of label backdrop.
        /// </summary>
        public int? BackdropPaddingX { get; set; }
        /// <summary>
        /// Vertical padding of label backdrop.
        /// </summary>
        public int? BackdropPaddingY { get; set; }
        /// <summary>
        /// Adjustment used when calculating the minimum data value. If the data has a value which is less than suggestedMin, then suggestedMin will be ignored
        /// </summary>
        public int? SuggestedMin { get; set; }
        /// <summary>
        /// Adjustment used when calculating the maximum data value. If the data has a value which is less than suggestedMax, then suggestedMax will be ignored
        /// </summary>
        public int? SuggestedMax { get; set; }
        /// <summary>
        /// Maximum rotation for tick labels when rotating to condense labels. Note: Rotation doesn't occur until necessary. Note: Only applicable to horizontal scales
        /// </summary>
        public int? MaxRotation { get; set; }
        /// <summary>
        /// Minimum rotation for tick labels
        /// </summary>
        public int? MinRotation { get; set; }
        /// <summary>
        /// Flips tick labels around axis, displaying the labels inside the chart instead of outside. Note: Only applicable to vertical scales.
        /// </summary>
        public bool? Mirror { get; set; }
        /// <summary>
        /// Maximum number of ticks and gridlines to show.
        /// </summary>
        public int? MaxTicksLimit { get; set; }
        /// <summary>
        /// If set, the scale ticks will be enumerated by multiple of stepSize, having one tick per increment. If not set, the ticks are labeled automatically using the nice numbers algorithm.
        /// </summary>
        public int? StepSize { get; set; }
        /// <summary>
        /// true, by default. If false, the Y-axis starts from the minimum value of the dataset
        /// </summary>
        public bool? BeginAtZero { get; set; }
    }
}
