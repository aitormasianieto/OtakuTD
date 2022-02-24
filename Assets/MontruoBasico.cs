using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontruoBasico : MonoBehaviour
{

    Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        posicion = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(5f, 0) * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Base"))
        {
            gameObject.transform.position = posicion;
        }
    }
}
