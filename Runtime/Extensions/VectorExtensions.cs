using UnityEngine;

namespace UnityLib.Core {

    public static class VectorExtensions {

        /// <summary>
        /// Clamps all the coordinates of the source vector between min and max.
        /// </summary>
        /// <param name="src">Vector</param>
        /// <param name="min">Min value</param>
        /// <param name="max">Max value</param>
        /// <returns></returns>
        public static Vector3 Clamp(this Vector3 src, Vector3 min, Vector3 max) =>
            new(Mathf.Clamp(src.x, min.x, max.x), Mathf.Clamp(src.y, min.y, max.y), Mathf.Clamp(src.z, min.z, max.z));

        /// <summary>
        /// Clamps the x coordinate of the source vector between min and max.
        /// </summary>
        /// <param name="src">Vector</param>
        /// <param name="min">Min value</param>
        /// <param name="max">Max value</param>
        /// <returns></returns>
        public static Vector3 ClampX(this Vector3 src, float min, float max) =>
            new(Mathf.Clamp(src.x, min, max), src.y, src.z);

        /// <summary>
        /// Clamps the y coordinate of the source vector between min and max.
        /// </summary>
        /// <param name="src">Vector</param>
        /// <param name="min">Min value</param>
        /// <param name="max">Max value</param>
        /// <returns></returns>
        public static Vector3 ClampY(this Vector3 src, float min, float max) =>
            new(src.x, Mathf.Clamp(src.y, min, max), src.z);

        /// <summary>
        /// Clamps the z coordinate of the source vector between min and max.
        /// </summary>
        /// <param name="src">Vector</param>
        /// <param name="min">Min value</param>
        /// <param name="max">Max value</param>
        /// <returns></returns>
        public static Vector3 ClampZ(this Vector3 src, float min, float max) =>
            new(src.x, src.y, Mathf.Clamp(src.z, min, max));

        /// <summary>
        /// Clamps all the coordinates of the source vector between min and max.
        /// </summary>
        /// <param name="src">Vector</param>
        /// <param name="min">Min value</param>
        /// <param name="max">Max value</param>
        /// <returns></returns>
        public static Vector2 Clamp(this Vector2 src, Vector2 min, Vector2 max) =>
            new(Mathf.Clamp(src.x, min.x, max.x), Mathf.Clamp(src.y, min.y, max.y));

        /// <summary>
        /// Clamps the x coordinate of the source vector between min and max.
        /// </summary>
        /// <param name="src">Vector</param>
        /// <param name="min">Min value</param>
        /// <param name="max">Max value</param>
        /// <returns></returns>
        public static Vector2 ClampX(this Vector2 src, float min, float max) =>
            new(Mathf.Clamp(src.x, min, max), src.y);

        /// <summary>
        /// Clamps the y coordinate of the source vector between min and max.
        /// </summary>
        /// <param name="src">Vector</param>
        /// <param name="min">Min value</param>
        /// <param name="max">Max value</param>
        /// <returns></returns>
        public static Vector2 ClampY(this Vector2 src, float min, float max) =>
            new(src.x, Mathf.Clamp(src.y, min, max));
    }
}
