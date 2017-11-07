namespace ChartJS.Helpers.MVC
{
    public class ChartOptionsScales
    {
        /// <summary>
        /// configuration of the x-axis
        /// </summary>
        public ChartOptionsScalesAxes[] XAxes { get; set; }
        /// <summary>
        /// configuration of the y-axis
        /// </summary>
        public ChartOptionsScalesAxes[] YAxes { get; set; }
    }
    public class ChartOptionsScalesAxes
    {
        /// <summary>
        /// If set to false the axis is hidden from view.
        /// </summary>
        public bool? Display { get; set; }
        /// <summary>
        /// The ID is used to link datasets and scale axes together. 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// </summary>
        public int? Weight { get; set; }
        /// <summary>
        /// Tick configuration
        /// </summary>
        public ChartOptionsScalesAxesTicks Ticks { get; set; }
        /// <summary>
        /// Position of the axis in the chart
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Set to true in the bar chart, otherwise false by default. 
        /// If true, extra space is added to the both edges and the axis is scaled to fit into the chart area
        /// </summary>
        public bool? Offset { get; set; }
        /// <summary>
        /// Scale title configuration
        /// </summary>
        public ChartScaleLabel ScaleLabel { get; set; }
        /// <summary>
        /// Grid line configuration
        /// </summary>
        public ChartOptionsScaleGridLines GridLines { get; set; }
        /// <summary>
        /// Line charts can be configured into stacked area charts by changing the settings on the y axis to enable stacking. Stacked area charts can be used to show how one data trend is made up of a number of smaller pieces.
        /// </summary>
        public bool? Stacked { get; set; }
    }
    public class ChartOptionsScalesAxesTicks : ChartLabel
    {
        /// <summary>
        /// If true, show tick marks
        /// </summary>
        public bool? Display { get; set; } = true;
        /// <summary>
        /// Reverses order of tick labels.
        /// </summary>
        public bool? Reverse { get; set; } = false;
        /// <summary>
        /// If true, automatically calculates how many tick labels that can be shown and hides tick labels accordingly. Turn it off to show all tick labels no matter what
        /// </summary>
        public bool? AutoSkip { get; set; } = true;
        /// <summary>
        /// Padding between the ticks on the horizontal axis when autoSkip is enabled. Note: Only applicable to horizontal scales
        /// </summary>
        public int? AutoSkipPadding { get; set; } = 0;
        /// <summary>
        /// The minimum value of the labels to display. If you want to box the minimum value of the auto-generated integeral label values, use suggestedMin 
        /// </summary>
        public string Min { get; set; }
        /// <summary>
        /// The maximum value of the labels to display. If you want to box the maximum value of the auto-generated integeral label values, use suggestedMax
        /// </summary>
        public string Max { get; set; }
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
        public int? MaxRotation { get; set; } = 90;
        /// <summary>
        /// Minimum rotation for tick labels
        /// </summary>
        public int? MinRotation { get; set; } = 0;
        /// <summary>
        /// Flips tick labels around axis, displaying the labels inside the chart instead of outside. Note: Only applicable to vertical scales.
        /// </summary>
        public bool? Mirror { get; set; } = false;
        /// <summary>
        /// Maximum number of ticks and gridlines to show.
        /// </summary>
        public int? MaxTicksLimit { get; set; } = 11;
        /// <summary>
        /// If set, the scale ticks will be enumerated by multiple of stepSize, having one tick per increment. If not set, the ticks are labeled automatically using the nice numbers algorithm.
        /// </summary>
        public int? StepSize { get; set; }
        /// <summary>
        /// true, by default. If false, the Y-axis starts from the minimum value of the dataset
        /// </summary>
        public bool? BeginAtZero { get; set; } = true;
    }
}
