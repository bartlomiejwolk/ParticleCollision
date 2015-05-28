using UnityEditor;
using UnityEngine;

namespace ParticleCollisionEx {

    [CustomEditor(typeof(ParticleCollision))]
    [CanEditMultipleObjects]
    public sealed class ParticleCollisionEditor : Editor {
        #region FIELDS

        private ParticleCollision Script { get; set; }

        #endregion FIELDS

        #region SERIALIZED PROPERTIES

        private SerializedProperty description;
        private SerializedProperty particleCollisionCallback;

        #endregion SERIALIZED PROPERTIES

        #region UNITY MESSAGES

        public override void OnInspectorGUI() {
            serializedObject.Update();

            DrawVersionLabel();
            DrawDescriptionTextArea();

            EditorGUILayout.Space();

            DrawParticleCollisionCallbackControl();

            serializedObject.ApplyModifiedProperties();
        }
        private void OnEnable() {
            Script = (ParticleCollision)target;

            description = serializedObject.FindProperty("description");
            particleCollisionCallback =
                serializedObject.FindProperty("particleCollisionCallback");
        }

        #endregion UNITY MESSAGES

        #region INSPECTOR CONTROLS
        private void DrawParticleCollisionCallbackControl() {
            EditorGUILayout.PropertyField(particleCollisionCallback);
        }


        private void DrawVersionLabel() {
            EditorGUILayout.LabelField(
                string.Format(
                    "{0} ({1})",
                    ParticleCollision.Version,
                    ParticleCollision.Extension));
        }

        private void DrawDescriptionTextArea() {
            description.stringValue = EditorGUILayout.TextArea(
                description.stringValue);
        }

        #endregion INSPECTOR

        #region METHODS

        [MenuItem("Component/ParticleCollision")]
        private static void AddEntryToComponentMenu() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(typeof(ParticleCollision));
            }
        }

        #endregion METHODS
    }

}