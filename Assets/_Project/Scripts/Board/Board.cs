using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Board : MonoBehaviour
{
    [Header("Board Size")]
    [Range(1, 2000)][SerializeField] protected int hexOnBoardInX;
    [Range(1, 2000)][SerializeField] protected int hexOnBoardInY;

    [Header("Spacing Between Hex")] 
    [Range(0, 2)] [SerializeField] protected float spaceInX;
    [Range(0, 2)] [SerializeField] protected float spaceInY;
    [Range(0, 2)] [SerializeField] protected float hexShift;
    [SerializeField] protected bool isGenerateOnStart;

    public List<GameObject> objects;

    private bool isShifted;

    protected virtual void InitBoard(GameObject _gameObject)
    {
        float tempX = 0;
        float tempY = 0;
        bool isUse = false;

        for (int i = 0; i < hexOnBoardInY; i++)
        {
            tempY++;
            if (isShifted)
            {
                tempX = hexShift;
                isShifted = false;
            }
            else
            {
                tempX = 0;
                isShifted = true;
            }
            
            for (int j = 0; j < hexOnBoardInX; j++)
            {
                GameObject temp = Instantiate(_gameObject);
                temp.transform.position =
                    new Vector3(tempX + spaceInX, tempY, temp.transform.position.z);
                tempX = temp.transform.position.x;
                temp.SetActive(true);
                temp.transform.SetParent(transform);
                temp.name += "" + i + j;
                objects.Add(temp);
            }
        }
    }
}
