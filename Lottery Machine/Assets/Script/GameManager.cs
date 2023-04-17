using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // Initialize Variables
    public Button spin;
    public DisplayManager displayManager;
    public bool isButtonPressed = false;
    public TMP_Text moneyText;
    public int moneyAmount = 0;
    
    // Initialize Array
    public GameObject[][] Symbols;
    
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
        
        displayManager = gameObject.GetComponent<DisplayManager>();
        moneyText = GameObject.Find("#").GetComponent<TMP_Text>();

    } 
    

    
    // TODO Button CLick function
    public void SpinSlot()
    {
        Debug.Log("Button Clicked");
        
        // Add button function below

        displayManager.Spin();
        isButtonPressed = true;

    }

    private void Update()
    {
        moneyText.text = moneyAmount.ToString();
    }
}
