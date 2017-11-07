namespace ChartJS.Helpers.MVC
{
    public class ChartOptionsHover
    {
        /// <summary>
        /// Sets which elements appear in the tooltip
        /// </summary>
        public string Mode { get; set; }
        /// <summary>
        /// if true, the mode only applies when the mouse position intersects an item on the chart.
        /// </summary>
        public bool? Intersect { get; set; }
        /// <summary>
        /// Can be set to 'x', 'y', or 'xy' to define which directions are used in calculating distances.
        /// </summary>
        public string Axis { get; set; }
        /// <summary>
        /// Duration in milliseconds it takes to animate style change
        /// </summary>
        public int? AnimationDuration { get; set; } 
    }
}
