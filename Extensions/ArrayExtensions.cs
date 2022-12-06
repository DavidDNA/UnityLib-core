using System;
using System.Collections.Generic;
using System.Linq;

public static class ArrayExtensions {
    private static Random rand = new Random();

    // Return a random item from an array.
    public static T GetRandomItem<T>(this T[] items) {
        return items[rand.Next(0, items.Length)];
    }

    // Return a random item from a list.
    public static T GetRandomItem<T>(this List<T> items) {
        return items[rand.Next(0, items.Count)];
    }

    // Return a random item from a list.
    public static T GetRandomItem<T>(this IList<T> items) {
        return items[rand.Next(0, items.Count)];
    }

    // Returns a random item from an enumerable
    public static T GetRandomItem<T>(this IEnumerable<T> items) {
        return items.ElementAt(rand.Next(0, items.Count()));
    }

    public static T[] Shuffle<T>(this T[] array) {
        return array.ToList().Shuffle().ToArray();
    }

    public static IList<T> Shuffle<T>(this IList<T> list) {
        int n = list.Count;
        while (n > 1) {
            n--;
            int k = rand.Next(0, n);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
        return list;
    }
}