using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityLib.Core {

    public static class ArrayExtensions {

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
        public static T GetRandomItem<T>(this T[] items) {
            return items[rand.Next(0, items.Length)];
        }

        /// <summary>
        /// Returns a random item from a collection which implements the IList interface.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static T GetRandomItem<T>(this IList<T> items) {
            return items[rand.Next(0, items.Count)];
        }

        /// <summary>
        /// Returns a random item from the given IEnumerable.
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="items">source enumerable</param>
        /// <returns></returns>
        public static T GetRandomItem<T>(this IEnumerable<T> items) {
            return items.ElementAt(rand.Next(0, items.Count()));
        }

        /// <summary>
        /// Returns a shuffled copy of the given source array.
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="array">source array</param>
        /// <returns></returns>
        public static T[] Shuffle<T>(this T[] array) {
            return array.ToList().Shuffle().ToArray();
        }

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
                n--;
                int k = rand.Next(0, n);
                T value = copy[k];
                copy[k] = copy[n];
                copy[n] = value;
            }
            return copy;
        }
    }
}