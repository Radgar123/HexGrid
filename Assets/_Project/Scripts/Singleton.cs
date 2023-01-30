using System;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T: MonoBehaviour
{
   private static readonly Lazy<T> LazyInstance = new Lazy<T>(CreateSingleton);

   public static T Instance => LazyInstance.Value;

   private static T CreateSingleton()
   {
      var ownerGameObject = new GameObject($"{typeof(T).Name} (singleton)");
      var instance = ownerGameObject.AddComponent<T>();
      DontDestroyOnLoad(ownerGameObject);
      return instance;
   }
}
