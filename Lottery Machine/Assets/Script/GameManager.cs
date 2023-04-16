using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // Initialize Button
    
    public Button spin;
    void Start()
    {
        // Get Button reference and set click function to "SpinSlot" function below
        spin = GameObject.Find("Spin").GetComponent<Button>();
        spin.onClick.AddListener(SpinSlot);
    }
    

    
    // TODO Button CLick function
    public static void SpinSlot()
    {
        Debug.Log("Button Clicked");
        
        // Add button function below
        
        
        
    }
    
    
    
    
}
