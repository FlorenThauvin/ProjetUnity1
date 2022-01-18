using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn2 : MonoBehaviour 
 {
     protected bool letPlay = true;
     
     public void Update()
     {
         if(Input.GetKeyDown(KeyCode.E))
         {
             letPlay = !letPlay;
         }
     
         if(letPlay)
         {
             if(!gameObject.GetComponent<ParticleSystem>().isPlaying)
             {
                 gameObject.GetComponent<ParticleSystem>().Play();
             }
         }else{
             if(gameObject.GetComponent<ParticleSystem>().isPlaying)
             {
                 gameObject.GetComponent<ParticleSystem>().Stop();
             }
         }
     }
 }