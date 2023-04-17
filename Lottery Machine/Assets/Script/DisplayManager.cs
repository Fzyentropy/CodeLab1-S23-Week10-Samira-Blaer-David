using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DisplayManager : MonoBehaviour
{
    private GameManager gameManager;

    private int[,] tbd = new int[5,3];

    public float xSpacing = 5;

    public float ySpacing = 5;

    public Transform generateStartPos;

    void Start()
    {
        gameManager = GetComponent<GameManager>();

        //Generate the array for test
        // for (int x = 0; x < 5; x++)
        // {
        //     for (int y = 0; y < 3; y++)
        //     {
        //         tbd[x, y] = Random.Range(0, 4);
        //     }
        // }
        
        DisplayItems();   
    }

    void Update()
    {
        
    }

    public void DisplayItems()
    {
        GameObject obj = new GameObject();
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                int index = tbd[x, y];
                switch (index)
                {
                    case 0:
                        obj = Instantiate(gameManager.seven);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, -y * ySpacing, 0f);
                        break;
                    
                    case 1:
                        obj = Instantiate(gameManager.cherry);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, -y * ySpacing, 0f);
                        break;
                    
                    case 2:
                        obj = Instantiate(gameManager.crown);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, -y * ySpacing, 0f);
                        break;
                    
                    case 3:
                        obj = Instantiate(gameManager.money);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, -y * ySpacing, 0f);
                        break;
                    
                    case 4:
                        obj = Instantiate(gameManager.bar);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, -y * ySpacing, 0f);
                        break;
                    
                }
            }
        }
    }
}
