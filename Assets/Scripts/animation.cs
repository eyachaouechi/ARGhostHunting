using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         transform.Rotate( Vector3.up * 1000f  * Time.deltaTime) ; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
