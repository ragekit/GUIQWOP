using UnityEngine;
 using System.Collections;
 using UnityEditor;
 [CustomEditor(typeof(TwoStepToggle))]
 public class TwoStepToggleEditor : Editor
 {
      public override void OnInspectorGUI()
      {
           base.OnInspectorGUI();
      }
 }