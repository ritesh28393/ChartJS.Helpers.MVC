namespace ChartJS.Helpers.MVC
{
    public class ChartOptions
    {
        /// <summary>
        /// Cartesian axes are used for line, bar, and bubble charts
        /// </summary>
        public ChartOptionsScales Scales { get; set; }
        /// <summary>
        /// Radial scale are used specifically for the radar and polar area chart types.
        /// </summary>
        public ChartOptionsScale Scale { get; set; }
        /// <summary>
        /// Styling of the Legend
        /// </summary>
        public ChartOptionsLegend Legend { get; set; }
        /// <summary>
        /// Styling of the title
        /// </summary>
        public ChartOptionsTitle Title { get; set; }
        /// <summary>
        /// The tooltip configuration is passed here
        /// </summary>
        public ChartOptionsTooltip Tooltips { get; set; }
        /// <summary>
        /// Hover configuration is passed here
        /// </summary>
        public ChartOptionsHover Hover { get; set; }
        /// <summary>
        /// The events option defines the browser events that the chart should listen to for tooltips and hovering
        /// </summary>
        public string[] Events { get; set; } = new string[] { ConstantEvent.MOUSEMOVE, ConstantEvent.MOUSEOUT, ConstantEvent.CLICK, ConstantEvent.TOUCHEND, ConstantEvent.TOUCHMOVE, ConstantEvent.TOUCHSTART };
    }
}
