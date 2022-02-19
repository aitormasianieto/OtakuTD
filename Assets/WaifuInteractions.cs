using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class WaifuInteractions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        AssetBundle.GetAllLoadedAssetBundles("");
        gameObject.GetComponent<Renderer>().enabled = false;
    }
}
