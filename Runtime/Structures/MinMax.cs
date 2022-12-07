using System;
using UnityEngine;

namespace UnityLib.Core {

    [Serializable]
    public struct MinMax {

        /// <summary>
        /// Lowest value.
        /// </summary>
        public float min;

        /// <summary>
        /// Highest value.
        /// </summary>
        public float max;

        /// <summary>
        /// Returns the difference between min and max.
        /// </summary>
        public float delta => max - min;

        /// <summary>
        /// Returns a random number between min (incl) and max (incl).
        /// </summary>
        /// <returns></returns>
        public float Random() =>
            UnityEngine.Random.Range(min, max);

        /// <summary>
        /// Gets the value given by the interpolation at t.
        /// </summary>
        /// <param name="t">value betweeon 0 and 1</param>
        /// <returns>the value at t</returns>
        public float Interpolate(float t) =>
            min + delta * Mathf.Clamp01(t);
    }

    [Serializable]
    public struct MinMaxInt {

        /// <summary>
        /// Lowest value.
        /// </summary>
        public int min;

        /// <summary>
        /// Highest value.
        /// </summary>
        public int max;

        /// <summary>
        /// Returns the difference between min and max.
        /// </summary>
        public int delta => max - min;

        /// <summary>
        /// Returns a random integer within the min - max sequence.
        /// Maximum value is included.
        /// </summary>
        /// <returns>a random integer</returns>
        public int RandomMaxIncluded() =>
            UnityEngine.Random.Range(min, max + 1);

        /// <summary>
        /// Returns a random integer within the min - max sequence.
        /// CAUTION: Maximum value is excluded - you may want to use RandomMaxIncluded
        /// </summary>
        /// <returns>A random integer</returns>
        public int Random() =>
            UnityEngine.Random.Range(min, max);

        /// <summary>
        /// Gets the value given by the interpolation at t.
        /// </summary>
        /// <param name="t">Value betweeon 0 and 1</param>
        /// <returns></returns>
        public int Interpolate(float t) =>
            Mathf.RoundToInt(min + delta * Mathf.Clamp01(t));
    }
}