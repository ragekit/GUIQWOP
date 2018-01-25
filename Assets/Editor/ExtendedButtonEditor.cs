using UnityEngine;
 using System.Collections;
 using UnityEditor;
 [CustomEditor(typeof(ExtendedButton))]
 public class ExtendedButtonEditor : Editor
 {
      public override void OnInspectorGUI()
      {
           base.OnInspectorGUI();
      }
 }