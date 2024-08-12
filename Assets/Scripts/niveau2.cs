using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niveau2 : MonoBehaviour
{    [SerializeField]
    GameObject canvas;
   
    // Start is called before the first frame update
    void Start()     {    
           
            StartCoroutine("LoadLevel");   
             }    
      IEnumerator LoadLevel()    {  
         
                     
             yield return new WaitForSeconds(3f);        
              Destroy(this.gameObject);
              GameObject.Find("ARCamera").GetComponent<ShootingTarget>().enabled=true; 
              canvas.SetActive(true); 
                  }  
                  
             } 
