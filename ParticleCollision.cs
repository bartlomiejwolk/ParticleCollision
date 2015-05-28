using UnityEngine;

namespace ParticleCollisionEx {

    public sealed class ParticleCollision : MonoBehaviour {

        #region CONSTANTS

        public const string Version = "v0.1.0";
        public const string Extension = "ParticleCollision";

        #endregion

        #region DELEGATES
        #endregion

        #region EVENTS
        #endregion

        #region FIELDS

#pragma warning disable 0414
        /// <summary>
        ///     Allows identify component in the scene file when reading it with
        ///     text editor.
        /// </summary>
        [SerializeField]
        private string componentName = "ParticleCollision";
#pragma warning restore0414

        #endregion

        #region INSPECTOR FIELDS

        [SerializeField]
        private string description = "Description";

        [SerializeField]
        private ParticleCollisionCallback particleCollisionCallback;

        #endregion

        #region PROPERTIES

        /// <summary>
        ///     Optional text to describe purpose of this instance of the component.
        /// </summary>
        public string Description {
            get { return description; }
            set { description = value; }
        }

        public ParticleCollisionCallback ParticleCollisionCallback {
            get { return particleCollisionCallback; }
            set { particleCollisionCallback = value; }
        }

        #endregion

        #region UNITY MESSAGES

        private void Awake() { }

        private void FixedUpdate() { }

        private void LateUpdate() { }

        private void OnEnable() { }

        private void Reset() { }

        private void Start() { }

        private void Update() { }

        private void OnValidate() { }

        private void OnCollisionEnter(Collision collision) { }

        private void OnCollisionStay(Collision collision) { }

        private void OnCollisionExit(Collision collision) { }

        private void OnParticleCollision(GameObject other) {
            ParticleCollisionCallback.Invoke(other);
        }

        #endregion

        #region EVENT INVOCATORS
        #endregion

        #region EVENT HANDLERS
        #endregion

        #region METHODS
        #endregion

    }

}