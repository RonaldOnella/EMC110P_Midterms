using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    public GameObject ReloadExit;
    public GameObject FinishTrig;
    public GameObject CarControl;
    public GameObject HalfwayTrig;
    public GameObject CarControlDeac;

    void OnTriggerEnter() //changes object state when triggered(hit by AI or player car)
    {
        CarControl.SetActive(false);
        CarControlDeac.SetActive(true);
        ReloadExit.SetActive(true);
        FinishTrig.SetActive(false);
        HalfwayTrig.SetActive(true);

    }
}
