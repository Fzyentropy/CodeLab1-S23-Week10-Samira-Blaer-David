using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // Initialize Button
    public Button spin;
    
    // Initialize Array
    public GameObject[][] Symbols;
    
    // Get Art reference
    // public Sprite seven;
    // public Sprite bar;
    // public Sprite cherry;
    // public Sprite crown;
    // public Sprite money;
    
    // Get Art reference prefab ver
    public GameObject seven;
    public GameObject bar;
    public GameObject cherry;
    public GameObject crown;
    public GameObject money;
    
    
    void Start()
    {
        // Get Button reference and set click function to "SpinSlot" function below
        spin = GameObject.Find("Spin").GetComponent<Button>();
        spin.onClick.AddListener(SpinSlot);
    }
    

    
    // TODO Button CLick function
    public void SpinSlot()
    {
        Debug.Log("Button Clicked");
        
        // Add button function below
        

    }
    
    
    
    
}
