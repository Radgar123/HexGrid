using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : Singleton<Pooling>
{
   [Header("Object to pool")] 
   [SerializeField] private GameObject objectToPool;
   [SerializeField] private int _numberOfObjectToPool;
   [HideInInspector] public List<GameObject> pooledObject;

   private void Awake()
   {
      CreatePool();
   }

   private void CreatePool()
   {
      for (int i = 0; i < _numberOfObjectToPool; i++)
      {
         GameObject temp = Instantiate(objectToPool);
         temp.SetActive(false);
         pooledObject.Add(temp);
         temp.transform.SetParent(transform);
      }
   }

   public GameObject GetPooledObject()
   {
      foreach (var obj in pooledObject)
      {
         if (!obj.activeInHierarchy)
         {
            return obj;
         }
      }
      return null;
   }

}
