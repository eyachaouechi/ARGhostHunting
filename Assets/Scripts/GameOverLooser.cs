using UnityEngine; 
public class GameOverLooser: MonoBehaviour {   
      public bool over=false;
     
      [SerializeField]     
      GameObject GameOver; 
      [SerializeField]     
      GameObject Canvas; 
      
      GameObject enemy;
      [SerializeField]  
      GameObject background;
      void start(){
        enemy = GameObject.Find("Capsule") ; 
        
       
        
      }
  void OnCollisionEnter(Collision collision )   
        { Debug.Log($"{gameObject.name} is colliding with {collision.collider.name}");
              
            background.GetComponent<AudioSource>().GetComponent<AudioSource>().Stop(); 
              GameOver.SetActive(true); 
               Canvas.SetActive(false);   
              Destroy(enemy);
              over=true;
               }
             
     
         }