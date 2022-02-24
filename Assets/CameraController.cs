using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                gameObject.transform.position = gameObject.transform.position - new Vector3(0.01f, 0);
            }
            if (Input.GetAxis("Mouse X") < 0)
            {
                gameObject.transform.position = gameObject.transform.position + new Vector3(0.01f, 0);
            }
            if (Input.GetAxis("Mouse Y") > 0)
            {
                gameObject.transform.position = gameObject.transform.position - new Vector3(0, 0.01f);
            }
            if (Input.GetAxis("Mouse Y") < 0)
            {
                gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0.01f);
            }
        }
    }
}
