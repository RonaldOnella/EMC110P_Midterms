using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CarCon2 : MonoBehaviour
{

    public GameObject CarControl;
    public GameObject AIControl1;
    public GameObject AIControl2;
    public GameObject AIControl3;

    void Start()
    {
        //fetches and deactivates scripts on specified folder
        CarControl.GetComponent<CarController>().enabled = false; //disables user car controls
        
        
        //disables AI controls
        CarControl.GetComponent<CarUserControl>().enabled = false;
        AIControl1.GetComponent<CarAIControl>().enabled = false;
        AIControl2.GetComponent<CarAIControl>().enabled = false;
        AIControl3.GetComponent<CarAIControl>().enabled = false;
    }
}