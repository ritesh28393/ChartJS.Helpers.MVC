namespace ChartJS.Helpers.MVC
{
    public class ChartOptionsElementsRectngle
    {
        /// <summary>
        /// Bar fill color
        /// </summary>
        public string BackgroundColor { get; set; } = "rgba(0, 0, 0, 0.1)";
        /// <summary>
        /// Bar stroke width
        /// </summary>
        public int? BorderWidth { get; set; } = 0;
        /// <summary>
        /// Bar stroke color
        /// </summary>
        public string BorderColor { get; set; } = "rgba(0, 0, 0, 0.1)";
        /// <summary>
        /// Skipped (excluded) border: 'bottom', 'left', 'top' or 'right'.
        /// </summary>
        public string BorderSkipped { get; set; } = ConstantPosition.BOTTOM;
    }
}