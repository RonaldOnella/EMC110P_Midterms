using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cams : MonoBehaviour
{
    public GameObject Car;
    public float CarX;
    public float CarY;
    public float CarZ;
   
    void Update()
    {
        CarX = Car.transform.eulerAngles.x;
        CarY = Car.transform.eulerAngles.y;
        CarZ = Car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
        //make it so the X and Z angles are reversed from the direction of the camera, making the camera angle steady at all times
        // Y angle is kept constant
    }
}
