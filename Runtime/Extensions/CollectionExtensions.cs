using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityLib.Core {

    public static class CollectionExtensions {

        /// <summary>
        /// RNG.
        /// </summary>
        private static Random rand = new Random();

        /// <summary>
        /// Initialize the random with the given seed.
        /// </summary>
        /// <param name="seed"></param>
        public static void InitializeRandom(int seed) {
            rand = new Random(seed);
        }

        /// <summary>
        /// Returns a random item from an array.
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="items">source array</param>
        /// <returns></returns>
        public static T GetRandomItem<T>(this T[] items) =>
            items[rand.Next(0, items.Length)];

        /// <summary>
        /// Returns a random item from the given IEnumerable.
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="items">source enumerable</param>
        /// <returns></returns>
        public static T GetRandomItem<T>(this IEnumerable<T> items) =>
            items.ElementAt(rand.Next(0, items.Count()));

        /// <summary>
        /// Returns a random item from the given IList. Uses the
        /// already computed Count property instead of relying 
        /// on Linq.
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="items">source enumerable</param>
        /// <returns></returns>
        public static T GetRandomItem<T>(this IList<T> items) =>
            items[rand.Next(0, items.Count)];

        /// <summary>
        /// Returns a shuffled copy of the given source array.
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="array">source array</param>
        /// <returns></returns>
        public static T[] Shuffle<T>(this T[] array) =>
            array.ToList().Shuffle().ToArray();

        /// <summary>
        /// Returns a shuffled copy of the given source IList.
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="list">source list</param>
        /// <returns></returns>
        public static IList<T> Shuffle<T>(this IList<T> list) {
            IList<T> copy = list.ToList();
            int n = copy.Count;
            while (n > 1) {
                int k = rand.Next(n--);
                T value = copy[k];
                copy[k] = copy[n];
                copy[n] = value;
            }
            return copy;
        }
    }
}
