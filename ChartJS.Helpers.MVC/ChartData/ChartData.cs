namespace ChartJS.Helpers.MVC
{
    public class ChartData
    {
        /// <summary>
        /// this is labels for default axis. In cartesian, x-axis is the default axis
        /// </summary>
        public string[] Labels { get; set; }
        /// <summary>
        /// If ChartData.YLabels is defined and the axis is vertical, this will be used.
        /// </summary>
        public string[] YLabels { get; set; }
    }
}
