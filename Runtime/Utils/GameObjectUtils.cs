using System.Collections.Generic;
using UnityEngine;

namespace UnityLib.Core {

    public static class GameObjectUtils {

        /// <summary>
        /// Activates the given game objects.
        /// </summary>
        /// <param name="objects"></param>
        public static void Activate(IEnumerable<GameObject> objects) {
            foreach (var obj in objects) {
                obj.SetActive(true);
            }
        }

        /// <summary>
        /// Deactivates the given game objects.
        /// </summary>
        /// <param name="objects"></param>
        public static void Deactivate(IEnumerable<GameObject> objects) {
            foreach (var obj in objects) {
                obj.SetActive(false);
            }
        }

    }

}
