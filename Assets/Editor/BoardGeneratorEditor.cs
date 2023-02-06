using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BoardGenerator))]
public class BoardGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        BoardGenerator boardGenerator = (BoardGenerator)target;

        if (GUILayout.Button("Generate Board"))
        {
            boardGenerator.ClearList();
            boardGenerator.ClearBoard(true);
            boardGenerator.GenerateBoardOnMap();
            boardGenerator.SetTypesOnMap();
        }

        if (GUILayout.Button("Destroy Board"))
        {
            boardGenerator.ClearBoard(true);
        }

        if (GUILayout.Button("ClearList"))
        {
            boardGenerator.ClearList();
        }

        if (GUILayout.Button("Set Types On Map"))
        {
            boardGenerator.SetTypesOnMap();
        }
    }
    
}
