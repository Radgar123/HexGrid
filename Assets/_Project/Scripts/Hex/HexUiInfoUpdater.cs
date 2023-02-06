using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HexUiInfoUpdater : MonoBehaviour
{
    [Header("HexUI Object")] 
    public GameObject hexUiGameObject;
    public Image background;

    [Header("HexUI Parameters")] 
    public TextMeshProUGUI hexName;
    public TextMeshProUGUI isInteractableText;
    public TextMeshProUGUI typeName;
    public TextMeshProUGUI position;
    
    private void Awake()
    {
        DisableUI();
    }

    void Start()
    {
        GameManager.instance.infoUpdater = this;
        GameManager.instance.activeHexUI.AddListener(ActiveUI);
        GameManager.instance.disableHexUI.AddListener(DisableUI);
    }

    public void Test() => Debug.Log("UIUX");
    private void ActiveUI() => hexUiGameObject.SetActive(true);
    private void DisableUI() => hexUiGameObject.SetActive(false);
}
