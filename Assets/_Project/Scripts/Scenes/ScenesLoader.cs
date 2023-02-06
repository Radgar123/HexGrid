using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class ScenesLoader : MonoBehaviour
{
    [SerializeField] private List<string> scenesNames;

    private void OnEnable()
    {
        LoadScenes();
    }

    IEnumerator LoadYourAsyncScene(string sceneName)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }

    private void LoadScenes()
    {
        foreach (var scene in scenesNames)
        {
            StartCoroutine(LoadYourAsyncScene(scene));
        }
    }
}
