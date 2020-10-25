using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CarCon : MonoBehaviour
{

    public GameObject CarControl;
    public GameObject AIControl1;
    public GameObject AIControl2;
    public GameObject AIControl3;

    void Start() 
    {
        //fetches and activates scripts on specified folder
        CarControl.GetComponent<CarController>().enabled = true; //enables user car controls after countdown

        //enables AI controls after countdown
        CarControl.GetComponent<CarUserControl>().enabled = true;
        AIControl1.GetComponent<CarAIControl>().enabled = true;
        AIControl2.GetComponent<CarAIControl>().enabled = true;
        AIControl3.GetComponent<CarAIControl>().enabled = true;
    }
}