namespace ChartJS.Helpers.MVC
{
    public class ChartOptionsTooltip
    {
        /// <summary>
        /// specify whether to enable tooltip or not 
        /// </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// Sets which elements appear in the tooltip
        /// </summary>
        public string Mode { get; set; }
        /// <summary>
        /// if true, the mode only applies when the mouse position intersects an item on the chart.
        /// </summary>
        public bool? Intersect { get; set; }
        /// <summary>
        /// Possible modes are:
        /// average -  will place the tooltip at the average position of the items displayed in the tooltip, and
        /// nearest - will place the tooltip at the position of the element closest to the event position
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Can be set to 'x', 'y', or 'xy' to define which directions are used in calculating distances.
        /// </summary>
        public string Axis { get; set; }
        /// <summary>
        /// Duration in milliseconds it takes to animate style change
        /// </summary>
        public int? AnimationDuration { get; set; }
        #region Tooltip Style
        /// <summary>
        /// Background color of the tooltip
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// font family of the title of the tooltip
        /// </summary>
        public string TitleFontFamily { get; set; }
        /// <summary>
        /// font size of the title of the tooltip
        /// </summary>
        public int? TitleFontSize { get; set; }
        /// <summary>
        /// font style of the title of the tooltip
        /// </summary>
        public string TitleFontStyle { get; set; }
        /// <summary>
        /// color of the title of the tooltip
        /// </summary>
        public string TitleFontColor { get; set; }
        /// <summary>
        /// Spacing to add to top and bottom of each title line.
        /// </summary>
        public int? TitleSpacing { get; set; }
        /// <summary>
        /// Margin to add on bottom of title section.
        /// </summary>
        public int? TitleMarginBottom { get; set; }
        /// <summary>
        /// font family of the body of the tooltip
        /// </summary>
        public string BodyFontFamily { get; set; }
        /// <summary>
        /// font size of the body of the tooltip
        /// </summary>
        public int? BodyFontSize { get; set; }
        /// <summary>
        /// font style of the body of the tooltip
        /// </summary>
        public string BodyFontStyle { get; set; }
        /// <summary>
        /// color of the body of the tooltip
        /// </summary>
        public string BodyFontColor { get; set; }
        /// <summary>
        /// Spacing to add to top and bottom of each body line.
        /// </summary>
        public int? BodySpacing { get; set; }
        /// <summary>
        /// font family of the footer of the tooltip
        /// </summary>
        public string FooterFontFamily { get; set; }
        /// <summary>
        /// font size of the footer of the tooltip
        /// </summary>
        public int? FooterFontSize { get; set; }
        /// <summary>
        /// font style of the footer of the tooltip
        /// </summary>
        public string FooterFontStyle { get; set; }
        /// <summary>
        /// color of the footer of the tooltip
        /// </summary>
        public string FooterFontColor { get; set; }
        /// <summary>
        /// Spacing to add to top and bottom of each footer line.
        /// </summary>
        public int? FooterSpacing { get; set; }
        /// <summary>
        /// Margin to add before drawing the footer
        /// </summary>
        public int? FooterMarginTop { get; set; }
        /// <summary>
        /// Padding to add on left and right of tooltip
        /// </summary>
        public int? XPadding { get; set; }
        /// <summary>
        /// Padding to add on top and bottom of tooltip
        /// </summary>
        public int? YPadding { get; set; }
        /// <summary>
        /// Extra distance to move the end of the tooltip arrow away from the tooltip point
        /// </summary>
        public int? CaretPadding { get; set; }
        /// <summary>
        /// Size, in px, of the tooltip arrow
        /// </summary>
        public int? CaretSize { get; set; }
        /// <summary>
        /// Radius of tooltip corner curves
        /// </summary>
        public int? CornerRadius { get; set; }
        /// <summary>
        /// Color to draw behind the colored boxes when multiple items are in the tooltip
        /// </summary>
        public string MultiKeyBackground { get; set; }
        /// <summary>
        /// if true, color boxes are shown in the tooltip
        /// </summary>
        public bool? DisplayColors { get; set; }
        /// <summary>
        /// Color of the border
        /// </summary>
        public string BorderColor { get; set; }
        /// <summary>
        /// Size of the border
        /// </summary>
        public int? BorderWidth { get; set; }
        #endregion
    }
}
