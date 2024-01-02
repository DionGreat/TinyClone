using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(Map))]
public class MapEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Map myMap = (Map)target;
        myMap.gridWidth = EditorGUILayout.IntField("Width", myMap.gridWidth);
        myMap.gridHeight = EditorGUILayout.IntField("Height", myMap.gridHeight);
        myMap.prefab = (GameObject)EditorGUILayout.ObjectField("Prefab", myMap.prefab, typeof(GameObject), true);

        if (GUILayout.Button("Build Grid"))
        {
            myMap.Generate();
        }
        if (GUILayout.Button("Delete Grid"))
        {
            myMap.Delete();
        }
    }
}