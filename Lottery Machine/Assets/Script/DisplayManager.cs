using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DisplayManager : MonoBehaviour
{
    private GameManager gameManager;

    private int[,] slots;

    public float xSpacing = 5;

    public float ySpacing = 5;

    public Transform generateStartPos;

    public int width;

    public int height;

    public bool checkLock = true;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
        //set size of new array based on width and height variable
        slots = new int [width, height];
        
    }

    void Update()
    {
        if (checkLock)
        {
            if (SevenWin())
            {
                checkLock = false;
                gameManager.moneyAmount += 777;
                Debug.Log("Seven Win");
            }
            if (CherryWin())
            {
                checkLock = false;
                gameManager.moneyAmount += 5;
                Debug.Log("Cherry Win");
            }
            if (CrownWin())
            {
                checkLock = false;
                gameManager.moneyAmount += 50;
                Debug.Log("Crown Win");
            }
            if (CoinWin())
            {
                checkLock = false;
                gameManager.moneyAmount += 100;
                Debug.Log("Coin Win");
            }
            if (BarWin())
            {
                checkLock = false;
                gameManager.moneyAmount += 20;
                Debug.Log("Bar Win");
            }
        }
        
    }


    public void Spin()
    {
        // Generate the array for test
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                slots[x, y] = Random.Range(0, 5);
            }
        }

        if (GameObject.Find("Items") != null)
        {
            DestroyItems();
        }
        
        DisplayItems();   
    }

    
    public void DisplayItems()
    {
        GameObject obj;
        GameObject Items = new GameObject();
        Items.name = "Items";
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                int index = slots[x, y];
                switch (index)
                {
                    case 0:
                        obj = Instantiate(gameManager.seven);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, -y * ySpacing, 0f);
                        obj.transform.parent = Items.transform;
                        break;
                    
                    case 1:
                        obj = Instantiate(gameManager.cherry);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, -y * ySpacing, 0f);
                        obj.transform.parent = Items.transform;
                        break;
                    
                    case 2:
                        obj = Instantiate(gameManager.crown);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, -y * ySpacing, 0f);
                        obj.transform.parent = Items.transform;
                        break;
                    
                    case 3:
                        obj = Instantiate(gameManager.money);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, -y * ySpacing, 0f);
                        obj.transform.parent = Items.transform;
                        break;
                    
                    case 4:
                        obj = Instantiate(gameManager.bar);
                        obj.transform.position =
                            generateStartPos.position + new Vector3(x * xSpacing, -y * ySpacing, 0f);
                        obj.transform.parent = Items.transform;
                        break;
                    
                }
            }
        }
    }

    public void DestroyItems()
    {
        Destroy(GameObject.Find("Items"));
    }
    
    public bool SevenWin()
    {
        return Jackpot() == 0;
    }
    public bool CherryWin()
    {
        return Jackpot() == 1;
    }

    public bool CrownWin()
    {
        return Jackpot() == 2;
    }
    
    public bool CoinWin()
    {
        return Jackpot() == 3;
    }
    
    public bool BarWin()
    {
        return Jackpot() == 4;
    }
    

    public int Jackpot()
    {
        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                if (x == 0 && gameManager.isButtonPressed)
                {
                    if (slots[x, y] == slots[x + 1, y] && slots[x, y] == slots[x +2, y]
                        && slots[x, y] == slots[x + 3, y] && slots[x, y] == slots[x + 4, y])
                    {
                        return slots[x, y];
                    }
                    /*if (slots[x, y + 1] == slots[x + 1, y + 1] && slots[x, y + 1] == slots[x +2, y + 1]
                            && slots[x, y + 1] == slots[x + 3, y + 1] && slots[x, y + 1] == slots[x + 4, y + 1])
                    {
                        return slots[x, y];
                    }*/
                    /*if (slots[x, y + 2] == slots[x + 1, y + 2] && slots[x, y + 2] == slots[x +2, y + 2]
                            && slots[x, y + 2] == slots[x + 3, y + 2] && slots[x, y + 2] == slots[x + 4, y + 2])
                    {
                        return slots[x, y];
                    }*/
                }
            }
        }

        return 5;
    }
}
