namespace ChartJS.Helpers.MVC
{
    public class ChartTypePolarArea : IChartType
    {
        /// <summary>
        /// type of the chart
        /// </summary>
        public string Type { get; private set; } = ConstantType.POLARAREA;
        /// <summary>
        /// data and label of the chart
        /// </summary>
        public PolarAreaData Data { get; set; }
        /// <summary>
        /// configure style of the chart
        /// </summary>
        public PolarAreaOptions Options { get; set; }
    }
    public class PolarAreaData : ChartData
    {
        /// <summary>
        /// represent data sets
        /// </summary>
        public PolarAreaDataSets[] Datasets { get; set; }
    }
    public class PolarAreaDataSets : DoughnutDataSets
    {

    }
    public class PolarAreaOptions : ChartOptions
    {
        /// <summary>
        /// Starting angle to draw arcs for the first item in a dataset.
        /// default value : -0.5 * System.Math.PI
        /// </summary>
        public double? StartAngle { get; set; } = -0.5 * System.Math.PI;
        /// <summary>
        /// When set, these options apply to all objects of that type unless specifically overridden by the configuration attached to a dataset
        /// </summary>
        public PolarAreaElementsStyle Elements { get; set; }
    }
    public class PolarAreaElementsStyle
    {
        /// <summary>
        /// Arcs are used in the polar area, doughnut and pie charts.
        /// </summary>
        public ChartOptionsElementsArc Arc { get; set; }
    }

}
