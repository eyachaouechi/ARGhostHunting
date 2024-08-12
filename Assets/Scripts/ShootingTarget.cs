using System.Collections; 
using UnityEngine; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
public class ShootingTarget : MonoBehaviour  { 
RaycastHit hit; 
AudioSource MyAudioSource; 
public bool Boss=false;
GameObject Enemy;
GameObject ManagerEnnemys;
[SerializeField]
    GameObject victory;
    [SerializeField]
    GameObject canvas;
    [SerializeField] 
    AudioClip ShootSound, ExplosionSound, BossTheme; 
    [SerializeField] 
    GameObject prefabExplosion; 
    [SerializeField] 
    GameObject Boo; 
    [SerializeField] 
    Text txtScore; 
    private int score = 0; 
    public int Monscore         {   
            get { return score; } 
            set { score = value;    txtScore.text = "Score : " + score; }        } 
            private void Start()    {                
        GameObject.Find("Best Score").GetComponent<Text>().text="Best Score: "+PlayerPrefs.GetInt("score").ToString() ;
        MyAudioSource = GetComponent<AudioSource>(); 
        Enemy=GameObject.Find("Enemy");
        ManagerEnnemys=GameObject.Find("ManagerEnnemys");
    } 
  
void Update()   { 
        
        Vector2 center = new Vector2(Screen.width / 2, Screen.height / 2); 
        Ray ray = Camera.main.ScreenPointToRay(center); 
         if (Monscore==10){
           Boss=true;
            this.gameObject.GetComponent<AudioSource>().clip=BossTheme;
           this.gameObject.GetComponent<AudioSource>().Play();
           Boo.SetActive(true);
          Destroy(ManagerEnnemys);
           
       } 
       if (Input.GetButtonDown("Fire1"))  
        {  MyAudioSource.PlayOneShot(ShootSound); // lancer le bruitage de tir  
            if(Physics.Raycast(ray,out hit, Mathf.Infinity)) //Renvoie V si le rayon croise un collider 
            {   Destroy (hit.collider.transform.gameObject);
                Monscore++; 
                GameObject Go =  Instantiate(prefabExplosion,hit.transform.position,Quaternion.identity);
                MyAudioSource.PlayOneShot(ExplosionSound); // lancer le bruitage de l’explosion  
                Destroy(Go, 1f); 
            } 
             } // Détruire l’ennemi 
            
      if (Monscore>10){
          StartCoroutine("LoadMenu"); 
      }
      
   } 
   IEnumerator LoadMenu()    {  
          
           
 victory.SetActive(true);
        canvas.SetActive(false); 
             yield return new WaitForSeconds(5f);        
              SceneManager.LoadScene("Menu");    
                  }  
} 