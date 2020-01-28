using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public Score scoreManager;
    
    private void OnCollisionEnter(Collision collision) {

        switch(collision.gameObject.tag){
            case "House":
                print("Collision House");
                scoreManager.AddPoint(2);
                break;
            case "Tent":
                print("Collision Tent");
                scoreManager.AddPoint(2);
                break;
            case "Special":
                print("Player collided. destroy me");
                Destroy(gameObject);
                scoreManager.AddPoint(2);
                break;
            default:
                print("something wrong");
                break;
        } 
        // Destroy(gameObject);
    }
}
