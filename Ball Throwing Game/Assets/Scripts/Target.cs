using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Target : MonoBehaviour
{
    public Score scoreManager;
    
    private void OnCollisionEnter(Collision collision) {
        // print(gameObject.name);
        // print(gameObject.tag);

        switch(collision.gameObject.tag){
            case "Friendly":
                // print("Collision Plane");
                break;
            case "Player":
                switch(gameObject.tag){
                    case "Special":
                        // print(gameObject.name);
                        gameObject.tag = "Friendly";
                        Destroy(gameObject);
                        scoreManager.AddPoint(500);
                        break;
                    case "Tent":
                        // print("house");
                        scoreManager.AddPoint(10);
                        break;
                    default:
                        break;
                }
                break;
            default:
                print("something wrong");
                break;
        } 
        // Destroy(gameObject);
    }
}

