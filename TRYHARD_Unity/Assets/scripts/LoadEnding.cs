using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadEnding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount <1)
        {
            Application.LoadLevel("WinningSence");
        }
    }
}
