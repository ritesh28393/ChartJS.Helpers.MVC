namespace ChartJS.Helpers.MVC
{
    public class ChartOptionsLegend
    {
        /// <summary>
        /// specify whether to display legend or not
        /// </summary>
        public bool? Display { get; set; }
        /// <summary>
        /// specify the position of the legend
        /// </summary>
        public string Position { get; set; } = ConstantPosition.TOP;
        /// <summary>
        /// if true, legend will show datasets in reverse order
        /// </summary>
        public bool? Reverse { get; set; }
        /// <summary>
        /// specify the style of the text of the legend
        /// </summary>
        public ChartLegendLabel Labels { get; set; } = new ChartLegendLabel();
    }
}
