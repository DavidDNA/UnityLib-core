using UnityEngine;

namespace UnityLib.Core {
    public static class TransformUtils {
        /// <summary>
        /// Removes all children of the given parent.
        /// </summary>
        /// <param name="parent"></param>
        public static void ClearChildren(Transform parent) {
            foreach (Transform child in parent) {
                Object.Destroy(child.gameObject);
            }
        }
    }
}
