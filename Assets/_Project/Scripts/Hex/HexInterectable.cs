using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexInterectable : MonoBehaviour, IInterectable
{
    private void Start()
    {
        //GameManager.Instance.testEvent.AddListener(Test);
    }

    public void InteractionOnClick()
    {
        Debug.Log(gameObject.name);
        GameManager.instance.updateUI.Invoke();
    }
    
    
}

