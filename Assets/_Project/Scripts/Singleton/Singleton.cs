using System;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T: Singleton<T>
{
    public static T instance { get; set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(transform.gameObject);
            throw new System.Exception("An Instance of this singleton already exists !!!");
        }
        else
        {
            instance = (T) this;
        }
    }
}
