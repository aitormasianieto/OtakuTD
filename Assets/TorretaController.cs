using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
            float z = collision.gameObject.transform.position.x;
            Debug.Log(z);
            gameObject.transform.Rotate(new Vector3(0, 0, z * 5));
        
        
    }

}
