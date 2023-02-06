using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T Instance;

    public static T instance => GetInstance();

    private static T GetInstance()
    {
        if (Instance == null) FindInstance();
        return Instance;
    }

    private static void FindInstance()
    {
        var singleton = FindObjectOfType<T>();
            
        if (singleton == null)
            Debug.LogError($"No Object With Script: {nameof(T)}");
        else
            Instance = singleton;
    }
}
