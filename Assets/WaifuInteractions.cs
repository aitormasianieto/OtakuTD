using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class WaifuInteractions : MonoBehaviour
{

    public GameObject bocadillo;
    private bool seve = true;

    // Start is called before the first frame update
    void Start()
    {
        bocadillo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        bocadillo.SetActive(seve);
        seve = !seve;
    }
}
