using System;
using UnityEngine;

namespace UnityLib.Core {
    public class Timer : MonoBehaviour {
        private static int _refCount = 0;

        private Action<Timer> _callback;

        private float _tt;

        [SerializeField] private float _tx;

        /// <summary>
        /// Returns the total time.
        /// </summary>
        public float Time => _tt;

        /// <summary>
        /// Returns the current time.
        /// </summary>
        public float Tx => _tx;

        /// <summary>
        /// Returns the current relative time.
        /// </summary>
        public float Rx => _tx / _tt;

        /// <summary>
        /// Initializes the timer with the given values.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="callback"></param>
        public void Initialize(float time, Action<Timer> callback) {
            _tt = time;
            _tx = time;
            _callback = callback;
        }

        /// <summary>
        /// Updates the timer - decreases the time and watch for the end.
        /// </summary>
        private void Update() {
            if (_tx > 0f) {
                _tx -= UnityEngine.Time.deltaTime;

                if (_tx <= 0f) {
                    _tx = 0f;
                    End();
                }
            }
        }

        /// <summary>
        /// Don't destroy this object when another scene is loaded.
        /// </summary>
        public void DontDestroyOnLoad() {
            DontDestroyOnLoad(gameObject);
        }


        /// <summary>
        /// Removes the object.
        /// </summary>
        public void Remove() {
            Destroy(gameObject);
        }

        /// <summary>
        /// Ends the timer - releases the resources and raise the callback if any.
        /// </summary>
        public void End() {
            _callback?.Invoke(this);
            Remove();
        }

        /// <summary>
        /// Creates a new Timer instance.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static Timer Create(float time, Action<Timer> callback) {
            GameObject g = new GameObject($"Timer {++_refCount}");
            Timer t = g.AddComponent<Timer>();
            t.Initialize(time, callback);
            return t;
        }
    }
}
