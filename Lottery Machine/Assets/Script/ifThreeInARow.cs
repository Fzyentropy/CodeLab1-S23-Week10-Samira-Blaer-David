using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifThreeInARow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Cherry()
    {
        return Jackpot() == 1;
    }
    
    public bool Bar()
    {
        return Jackpot() == 2;
    }
    
    public bool Crown()
    {
        return Jackpot() == 3;
    }
    
    public bool Coin()
    {
        return Jackpot() == 4;
    }
    
    public bool Seven()
    {
        return Jackpot() == 5;
    }

    public int Jackpot()
    {
        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                if (x <= width - 2)
                {
                    if (grid[x, y] == grid[x + 1, y] && grid[x, y] == grid[x +2, y])
                    {
                        return grid[x, y];
                    }
                }
            }
        }

        return 0;
    }
}
