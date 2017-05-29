using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatObjectBehvior : MonoBehaviour {
    public float movementSpeed = 1;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("down"))
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 0, -5, Space.Self);
        }
        else if (Input.GetKey("left"))
        {
            transform.Rotate(0, 0, 5, Space.Self);
        }
    }
}
