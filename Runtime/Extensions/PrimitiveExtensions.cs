namespace UnityLib.Core {

    public static class PrimitiveExtensions {

        /// <summary>
        /// Returns tue if the value is between the min-max (both excluded) range.
        /// </summary>
        /// <param name="value">the value</param>
        /// <param name="min">min value</param>
        /// <param name="max">max value</param>
        /// <returns>true if between the range</returns>
        public static bool Between(this float value, float min, float max) =>
            value > min && value < max;

        /// <summary>
        /// Returns tue if the value is between the min-max (both excluded) range.
        /// </summary>
        /// <param name="value">the value</param>
        /// <param name="min">min value</param>
        /// <param name="max">max value</param>
        /// <returns>true if between the range</returns>
        public static bool Between(this int value, int min, int max) =>
            value > min && value < max;

        /// <summary>
        /// Returns true if the value is within the min-max (both included) range.
        /// </summary>
        /// <param name="value">the value</param>
        /// <param name="min">min value</param>
        /// <param name="max">max value</param>
        /// <returns>true if within the range</returns>
        public static bool Within(this float value, float min, float max) =>
            value >= min && value <= max;

        /// <summary>
        /// Returns true if the value is within the min-max (both incl.) range.
        /// </summary>
        /// <param name="value">the value</param>
        /// <param name="min">min value</param>
        /// <param name="max">max value</param>
        /// <returns>true if within the range</returns>
        public static bool Within(this int value, int min, int max) =>
            value >= min && value <= max;
    }
}
