using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start : MonoBehaviour
{
    public GameObject CountdownMan;
    public GameObject SpaceStartText;
    public GameObject ReloadInstruction;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) //Catches Return key(enter key) buttonpress
        {
            CountdownMan.SetActive(true); //starts countdown animation
            ReloadInstruction.SetActive(true); 
            SpaceStartText.SetActive(false); 
        }
    }
}