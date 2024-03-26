using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*20);
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 20);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 20);
        }
        /*else if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -25f);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(Vector3.up, 25f);
        }*/
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -50f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, 50f * Time.deltaTime);
        }
    }
}
