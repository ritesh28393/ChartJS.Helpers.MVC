using ChartJS.Helpers.MVC;

namespace ChartJS.Helpers.MVC
{
    public static class Chart
    {
        /// <summary>
        /// draws the canvas chart from the data provided
        /// </summary>
        /// <param name="chartTypeObject">chart type's object (type, data and options)</param>
        /// <param name="chartID">unique id of the canvas chart</param>
        /// <param name="height">height (px or %) of the canvas chart</param>
        /// <param name="width">width (px or %) of the canvas chart</param>
        /// <returns>return canvas chart</returns>
        public static string Draw<T>(this T chartTypeObject, string chartID, string height = "300px", string width = "500px") where T: IChartType
        {
            string chart = $"<div style='height:{height};width:{width}'>" + "\n";
            chart += $"<canvas id='{chartID}'></canvas>" + "\n";
            chart += "</div>" + "\n";
            chart += "<script>" + "\n";
            chart += $"var {chartID}_ctx = document.getElementById('{chartID}').getContext('2d');" + "\n";
            chart += $"var {chartID}_Chart = new Chart({chartID}_ctx, {{" + "\n";
            chart += MyConverter.ToJSON(chartTypeObject) + "\n";
            chart += "});" + "\n";
            chart += "</script>" + "\n";
            return chart;
        }
    }
}
namespace System.Web.Mvc
{
    public static class ChartHelper
    {
        /// <summary>
        /// draws the canvas chart from the data provided
        /// </summary>
        /// <typeparam name="T">chartType like line, bar, pie, doughnut</typeparam>
        /// <param name="helper">HtmlHelper class</param>
        /// <param name="chartID">unique id of the canvas chart</param>
        /// <param name="chartTypeObject">instance of chartType like line, bar, pie, doughnut</param>
        /// <param name="height">height (px or %) of the canvas chart</param>
        /// <param name="width">width (px or %) of the canvas chart</param>
        /// <returns></returns>
        public static IHtmlString ChartJS<T>(this HtmlHelper helper, string chartID, T chartTypeObject, string height = "300px", string width = "500px") where T : IChartType
        {
            return new MvcHtmlString(chartTypeObject.Draw(chartID, height, width));
        }
    }
}
