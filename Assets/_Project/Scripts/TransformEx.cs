using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadgarUtility
{
    public static class TransformEx
    {
        public static void DestroyAllObjectChildren(this Transform content)
        {
            if (content.childCount > 0)
            {
                List<GameObject> children = new List<GameObject>();
                foreach (Transform child in content)
                {
                    children.Add(child.gameObject);
                }

                content.DetachChildren();
                foreach (GameObject child in children)
                {
                    Object.Destroy(child);
                }
            }
        }
        
        public static void DestroyAllObjectChildren(this Transform content,bool inEditor)
        {
            if (content.childCount > 0)
            {
                List<GameObject> children = new List<GameObject>();
                foreach (Transform child in content)
                {
                    children.Add(child.gameObject);
                }

                content.DetachChildren();
                foreach (GameObject child in children)
                {
                    if (inEditor)
                        Object.DestroyImmediate(child);
                    else
                        Object.Destroy(child);
                }
            }
        }
        
        public static void DisableAllObjectChildren(this Transform content)
        {
            if (content.childCount > 0)
            {
                List<GameObject> children = new List<GameObject>();
                foreach (Transform child in content)
                {
                    children.Add(child.gameObject);
                }

                content.DetachChildren();
                foreach (GameObject child in children)
                {
                    child.SetActive(false);
                }
            }
        }

        public static void AddChildFromTransformToList(this Transform content,List<GameObject> objects)
        {
            List<GameObject> children = new List<GameObject>();
            foreach (Transform child in content)
            {
                children.Add(child.gameObject);
            }
            
            objects = children;
        }
    }
}
