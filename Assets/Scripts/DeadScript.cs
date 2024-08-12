using System.Collections; 
using UnityEngine; 
using UnityEngine.SceneManagement;

public class DeadScript : MonoBehaviour {   
    [SerializeField]    
    ShootingTarget1 STarget; 
      void Start()     {      
            StartCoroutine("LoadMenu");   
             }    
      IEnumerator LoadMenu()    {  
          int score = STarget.Monscore;       
           if(score> PlayerPrefs.GetInt("score")) {    
               PlayerPrefs.SetInt("score", score);         
                     }    
                     
             yield return new WaitForSeconds(5f);        
              SceneManager.LoadScene("Menu");    
                  }  
                  
             } 
 