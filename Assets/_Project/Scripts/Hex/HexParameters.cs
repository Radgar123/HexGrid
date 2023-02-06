using System.Collections;
using System.Collections.Generic;
using GameBoard;
using UnityEngine;

[System.Serializable]
public struct HexParameters
{
    public string name;
    [Range(0, 100)] public int percentageOnTheMap;
    public BoardField fieldType;
    public Color fieldColor;
    public bool isInteractable;
}
