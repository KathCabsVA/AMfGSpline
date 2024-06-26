
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridGenerator))]

public class GridGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GridGenerator gridGenerator = (GridGenerator)target;
        if (GUILayout.Button("Generate Grid"))
        {
            gridGenerator.GenerateGrid();
        }
        if (GUILayout.Button("ClearGrid"))
        {
            gridGenerator.ClearGrid();
        }
        if (GUILayout.Button("AssignMaterial"))
        {
            gridGenerator.AssignMaterial();
        }
    }

    [MenuItem("Tools/Generate Grid")]
    public static void GenerateGridMenu()
    {

        GridGenerator gridGenerator = FindObjectOfType<GridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.GenerateGrid();
        }
        else
        {
            Debug.LogError("No Grid Generator Found in Scene");
        }

    }

    [MenuItem("Tools/Clear Grid")]
    public static void ClearGridMenu()
    {

        GridGenerator gridGenerator = FindObjectOfType<GridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.ClearGrid();
        }
        else
        {
            Debug.LogError("No Grid Generator Found in Scene");
        }

    }


}
