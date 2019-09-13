using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{

    /*
   * Edouard Borissov
   * SpinPropellerX
   * Assignment 3
   * A script that makes the propeller of the plane spin.
   */


    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
