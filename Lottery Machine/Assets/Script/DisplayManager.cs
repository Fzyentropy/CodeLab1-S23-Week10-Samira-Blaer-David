using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayManager : MonoBehaviour
{
    private GameManager gameManager;

    private int[,] tbd;

    private float xSpacing = 1;

    private float ySpacing = 1;

    public Transform generateStartPos;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayItems();   
    }

    public void DisplayItems()
    {
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                int index = tbd[x, y];
                GameObject obj = new GameObject();
                switch (index)
                {
                    case 0:
                        obj = Instantiate(gameManager.seven);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, y * ySpacing, 0f);
                        break;
                    
                    case 1:
                        obj = Instantiate(gameManager.cherry);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, y * ySpacing, 0f);
                        break;
                    
                    case 2:
                        obj = Instantiate(gameManager.crown);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, y * ySpacing, 0f);
                        break;
                    
                    case 3:
                        obj = Instantiate(gameManager.money);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, y * ySpacing, 0f);
                        break;
                    
                    case 4:
                        obj = Instantiate(gameManager.bar);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, y * ySpacing, 0f);
                        break;
                    
                }
            }
        }
    }
}
