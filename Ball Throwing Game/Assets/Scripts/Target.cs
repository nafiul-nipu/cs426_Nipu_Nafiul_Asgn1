using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Target : MonoBehaviour
{
    public Score scoreManager;
    
    private void OnCollisionEnter(Collision collision) {

        switch(collision.gameObject.tag){
            case "Friendly":
                // print("Collision Plane");
                break;
            case "Player":
                // print("Player collided. destroy me");
                Destroy(gameObject);
                scoreManager.AddPoint();
                break;
            default:
                print("something wrong");
                break;
        } 
        // Destroy(gameObject);
    }
}