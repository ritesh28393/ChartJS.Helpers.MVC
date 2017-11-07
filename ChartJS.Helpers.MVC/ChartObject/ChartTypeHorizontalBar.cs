namespace ChartJS.Helpers.MVC
{
    public class ChartTypeHorizontalBar : IChartType
    {
        /// <summary>
        /// type of the chart
        /// </summary>
        public string Type { get; private set; } = ConstantType.HORIZONTALBAR;
        /// <summary>
        /// data and label of the chart
        /// </summary>
        public BarData Data { get; set; }
        /// <summary>
        /// configure style of the chart
        /// </summary>
        public BarOptions Options { get; set; }
    }

}
