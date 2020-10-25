using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject CarControls;
    public GameObject CarControlDeac;
    public GameObject ReloadInstruction;

    void Start() {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart () 
    {
        //dictates changes during countdown animation
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CarControlDeac.SetActive(false);
        CarControls.SetActive(true);
        ReloadInstruction.SetActive(false);
        


    }
}
