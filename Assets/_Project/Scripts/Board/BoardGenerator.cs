using System;
using System.Collections;
using System.Collections.Generic;
using GameBoard;
using RadgarUtility;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardGenerator : Board
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private List<HexParameters> objectsTypesOnMap;
    [SerializeField] private List<GameObject> hexes;

    private void OnEnable()
    {
        Debug.Log(hexOnBoardInX.ToString());
    }

    private void Awake()
    {
        GameManager.instance.cameraPos = new Vector2(hexOnBoardInX / 2, hexOnBoardInY / 2);
    }

    private void Start()
    {
        if (isGenerateOnStart)
        {
            ClearList();
            ClearBoard(true);
            GenerateBoardOnMap(); 
            SetTypesOnMap();
        }
    }
    
    public void GenerateBoardOnMap()
    {
        //InitBoard(objectToSpawn);
        base.InitBoard(objectToSpawn);
    }

    public void ClearBoard(bool inEditor) => transform.DestroyAllObjectChildren(inEditor);

    int t = 0;
    public void SetTypesOnMap()
    {
        /*foreach (var obj in objects)
        {
            obj.GetComponent<SpriteRenderer>().color = objectsTypesOnMap[0].fieldColor;
        }*/

        
        int baseCount = objects.Count;
        int sum = 0;
        foreach (var type in objectsTypesOnMap)
        {
            //float totalObjectsInType = type.percentageOnTheMap / baseCount;
            int totalObjectsInType = (int)Mathf.Round(baseCount * type.percentageOnTheMap / 100);
            sum += totalObjectsInType;
            for (int i = 0; i < totalObjectsInType; i++)
            {
                //int r = Random.Range(0, objects.Count);
                RandomBoardPlaces();
                
                objects[t].GetComponent<SpriteRenderer>().color = type.fieldColor;
                objects[t].GetComponent<Hex>().boardFieldType = type.fieldType;
                objects[t].GetComponent<Hex>().isInteractable = type.isInteractable;
                
            }
        }
        Debug.Log("Sum " + sum + " " + "Base " + baseCount);
    }

    public void ClearList() => objects.Clear();

    protected override void InitBoard(GameObject _gameObject)
    {
        base.InitBoard(_gameObject);
    }

    private void RandomBoardPlaces()
    {
         int r = Random.Range(0, objects.Count);

        if (objects[r].GetComponent<Hex>().boardFieldType != BoardField.None)
        {
            RandomBoardPlaces();
            Debug.Log("IsDuplicate!!");
        }
        else
        {
            t = r;
        }
    }
}
