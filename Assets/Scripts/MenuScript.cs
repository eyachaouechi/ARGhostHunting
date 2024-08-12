using UnityEngine; 
using UnityEngine.SceneManagement; 
public class MenuScript : MonoBehaviour {
        public void Play()     { 
                SceneManager.LoadScene("jeuAR");  
                         }     
        public void Exit()     {   
                 Application.Quit();   
                  } 
                 
                 } 