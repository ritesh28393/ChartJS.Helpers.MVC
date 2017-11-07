using System;

namespace ChartJS.Helpers.MVC
{
    public class ChartDataSets
    {
        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// this has to match the scale properties ChartOptionsScales.YAxes.ID. This is especially needed if multi-axes charts are used.
        /// </summary>
        public string YAxisID { get; set; }
        /// <summary>
        /// this has to match the scale properties ChartOptionsScales.XAxes.ID. This is especially needed if multi-axes charts are used.
        /// </summary>
        public string XAxisID { get; set; }
        /// <summary>
        /// represent data only on one axis
        /// </summary>
        public int[] LinearData { get; set; }
        /// <summary>
        /// represent data on x and y axis
        /// </summary>
        public XYdataItem[] XYData { get; set; }
        /// <summary>
        /// represent data on x and y axis, R represents the radius of the point on x,y axis, thus providing third dimension
        /// </summary>
        public XYRdataItem[] XYRData { get; set; }
    }
    public class XYdataItem
    {
        /// <summary>
        /// value for X-axis
        /// </summary>
        public int? X { get; set; }
        /// <summary>
        /// value for Y-axis
        /// </summary>
        public int? Y { get; set; }
    }
    public class XYRdataItem
    {
        /// <summary>
        /// value for X-axis
        /// </summary>
        public int? X { get; set; }
        /// <summary>
        /// value for Y-axis
        /// </summary>
        public int? Y { get; set; }
        /// <summary>
        /// value for radius of point
        /// </summary>
        public int? R { get; set; }
    }
}
