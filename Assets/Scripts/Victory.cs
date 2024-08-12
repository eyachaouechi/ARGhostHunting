using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{ [SerializeField]
    GameObject canvas;
    // Start is called before the first frame update
    void Start()     {   
        this.gameObject.SetActive(true);
        canvas.SetActive(false); 
                  }  
                  
             } 