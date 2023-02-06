using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoSingleton<GameManager>
{
    public Vector2 cameraPos;
    [HideInInspector] public HexUiInfoUpdater infoUpdater;
    [HideInInspector] public UnityEvent activeHexUI;
    [HideInInspector] public UnityEvent disableHexUI;
    [HideInInspector] public UnityEvent updateUI;
}
