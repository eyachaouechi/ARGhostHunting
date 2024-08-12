using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI1 : MonoBehaviour
{  float speed=0f;
   GameObject loss;
   GameObject Shoot;
  
    // Start is called before the first frame update
     void Awake () {
     loss = GameObject.Find("hitbox");
     Shoot = GameObject.Find("ARCamera");
 }
    void Start()
    {  
        speed=Random.Range(0.1f, 0.5f);
    }
    


    // Update is called once per frame
    void Update()
    {
           
       if ((loss.GetComponent<GameOverLooser>().over==false)&&(Shoot.GetComponent<ShootingTarget1>().lvl2==false)){
           transform.Translate(Vector3.forward*speed*Time.deltaTime);
        transform.LookAt(Camera.main.transform);
       }
       else{
          Destroy(this.gameObject);
          
       }
    }
}
