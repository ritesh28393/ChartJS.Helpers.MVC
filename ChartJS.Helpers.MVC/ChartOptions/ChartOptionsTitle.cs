namespace ChartJS.Helpers.MVC
{
    public class ChartOptionsTitle : ChartLabel
    {
        /// <summary>
        /// specify whether to display title of he chart or not
        /// </summary>
        public bool? Display { get; set; }
        /// <summary>
        /// Position of title
        /// </summary>
        public string position { get; set; } = ConstantPosition.TOP;
        /// <summary>
        /// Title text to display. each item in the string array is rendered on each next line
        /// </summary>
        public string[] Text { get; set; }
        /// <summary>
        /// Height of an individual line of text 
        /// </summary>
        public double? lineHeight { get; set; }
    }
}
