using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{    [SerializeField]     
GameObject PlaySound; 
    // Start is called before the first frame update
    public void playsong()
    {
        PlaySound.SetActive(true); 
    }

    // Update is called once per frame

}
