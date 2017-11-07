namespace ChartJS.Helpers.MVC
{
    public class ConstantMode
    {
        /// <summary>
        /// Finds all of the items that intersect the point.
        /// </summary>
        public const string POINT = "point";
        /// <summary>
        /// Gets the item that is nearest to the point
        /// </summary>
        public const string NEAREST = "nearest";
        /// <summary>
        /// Finds item at the same index. If the intersect setting is true, the first intersecting item is used to determine the index in the data. If intersect false the nearest item, in the x direction, is used to determine the index. x direction can be overridden by using 'axis' key
        /// </summary>
        public const string INDEX = "index";
        /// <summary>
        /// Finds items in the same dataset. If the intersect setting is true, the first intersecting item is used to determine the index in the data. If intersect false the nearest item is used to determine the index.
        /// </summary>
        public const string DATASET = "dataset";
        /// <summary>
        /// Returns all items that would intersect based on the X coordinate of the position only.
        /// </summary>
        public const string X = "x";
        /// <summary>
        /// Returns all items that would intersect based on the Y coordinate of the position only.
        /// </summary>
        public const string Y = "y";
    }
}
