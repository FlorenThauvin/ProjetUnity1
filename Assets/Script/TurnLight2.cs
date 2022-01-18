using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight2 : MonoBehaviour
{
    void Update(){
        if(Input.GetKeyDown(KeyCode.E)){
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
    }
}
