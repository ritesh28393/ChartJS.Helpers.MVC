namespace ChartJS.Helpers.MVC
{
    public class ChartTypePie : IChartType
    {
        /// <summary>
        /// type of the chart
        /// </summary>
        public string Type { get; private set; } = ConstantType.PIE;
        /// <summary>
        /// data and label of the chart
        /// </summary>
        public PieData Data { get; set; }
        /// <summary>
        /// configure style of the chart
        /// </summary>
        public PieOptions Options { get; set; }
    }
    public class PieData : ChartData
    {
        /// <summary>
        /// represent data sets
        /// </summary>
        public PieDataSets[] Datasets { get; set; }
    }
    public class PieDataSets : DoughnutDataSets
    {
        
    }
    public class PieOptions : ChartOptions
    {
        /// <summary>
        /// The percentage(0-100) of the chart that is cut out of the middle.
        /// </summary>
        public int? CutoutPercentage { get; set; } = 0;
        /// <summary>
        /// Starting angle to draw arcs from.
        /// default value : -0.5 * System.Math.PI
        /// </summary>
        public double? Rotation { get; set; } = -0.5 * System.Math.PI;
        /// <summary>
        /// Sweep to allow arcs to cover
        /// default value : 2 * System.Math.PI
        /// </summary>
        public double? Circumference { get; set; } = 2 * System.Math.PI;
        /// <summary>
        /// When set, these options apply to all objects of that type unless specifically overridden by the configuration attached to a dataset
        /// </summary>
        public PieElementsStyle Elements { get; set; }
    }
    public class PieElementsStyle
    {
        /// <summary>
        /// Arcs are used in the polar area, doughnut and pie charts.
        /// </summary>
        public ChartOptionsElementsArc Arc { get; set; }
    }

}
