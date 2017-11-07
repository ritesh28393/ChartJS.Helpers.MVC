namespace ChartJS.Helpers.MVC
{
    public class ChartOptionsElementsPoint
    {
        /// <summary>
        /// Point radius
        /// </summary>
        public int? Radius { get; set; } = 3;
        /// <summary>
        /// Point style
        /// </summary>
        public string PointStyle { get; set; } = ConstantPointStyle.CIRCLE;
        /// <summary>
        /// Point fill color
        /// </summary>
        public string BackgroundColor { get; set; } = "rgba(0,0,0,0.1)";
        /// <summary>
        /// Point stroke width.
        /// </summary>
        public int? BorderWidth { get; set; } = 1;
        /// <summary>
        /// Point stroke color
        /// </summary>
        public string BorderColor { get; set; } = "rgba(0,0,0,0.1)";
        /// <summary>
        /// Extra radius added to point radius for hit detection.
        /// </summary>
        public int? HitRadius { get; set; } = 1;
        /// <summary>
        /// Point radius when hovered.
        /// </summary>
        public int? HoverRadius { get; set; } = 4;
        /// <summary>
        /// Stroke width when hovered.
        /// </summary>
        public int? HoverBorderWidth { get; set; } = 1;
    }
}