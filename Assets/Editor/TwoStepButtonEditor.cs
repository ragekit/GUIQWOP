using UnityEngine;
 using System.Collections;
 using UnityEditor;
 [CustomEditor(typeof(TwoStepButton))]
 public class TwoStepToggleEditor : Editor
 {
      public override void OnInspectorGUI()
      {
           base.OnInspectorGUI();
      }
 }