using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        
        print(other.gameObject.tag);
        print("Trigger Detected");
        if(other.gameObject.tag == "Player"){
            PlayerMovement.moveSpeed += 5f;
        }
    }
}
