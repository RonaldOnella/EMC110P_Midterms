using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HalfwayTrigger : MonoBehaviour //trigger to activate finish line
{
    public GameObject FinishLineTrig;
    public GameObject HalfwayTrig;
    
    void OnTriggerEnter () //changes object settings when triggered (car passes/hits invisible object)
    {
        FinishLineTrig.SetActive(true);
        HalfwayTrig.SetActive(false);
    }
}
