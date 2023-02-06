using System;
using System.Collections;
using System.Collections.Generic;
using GameBoard;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HexInterectable))]
public class Hex : MonoBehaviour
{
    public BoardField boardFieldType;
    public bool isInteractable;
    [SerializeField] private HexInterectable _hexInterectable;

    private void Start()
    {
        _hexInterectable = transform.GetComponent<HexInterectable>();
        //GameManager.instance.updateUI.AddListener(UpdateInfo);
    }

    private void OnMouseDown()
    {
        if (isInteractable && _hexInterectable != null)
        {
            GameManager.instance.activeHexUI.Invoke();
            GameManager.instance.updateUI.RemoveListener(UpdateInfo);
            GameManager.instance.updateUI.AddListener(UpdateInfo);
            _hexInterectable.InteractionOnClick();
        }
        else
        {
            GameManager.instance.disableHexUI.Invoke();
        }
    }

    private void UpdateInfo()
    {
        GameManager.instance.infoUpdater.hexName.text = name;
        GameManager.instance.infoUpdater.isInteractableText.text = "Posiada Interakcje";
        GameManager.instance.infoUpdater.typeName.text = "Typ pola " + boardFieldType;
        GameManager.instance.infoUpdater.position.text = "X " + transform.position.x + " Y " + transform.position.y +
                                                         " Z " + transform.position.z;
    }
}
