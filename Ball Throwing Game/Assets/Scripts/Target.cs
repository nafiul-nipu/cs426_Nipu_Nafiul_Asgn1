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
                ProvidePoint();
                break;
            default:
                print("something wrong");
                break;
        } 
        // Destroy(gameObject);
    }

    private void ProvidePoint()
    {
        switch (gameObject.tag)
        {
            case "Special":
                gameObject.tag = "Friendly";
                Destroy(gameObject);
                scoreManager.AddPoint(100);
                break;
            case "Tent":
                scoreManager.AddPoint(10);
                break;
            case "Tree":
                scoreManager.AddPoint(20);
                break;
            case "Bush":
                scoreManager.AddPoint(10);
                break;
            case "Palm":
                scoreManager.AddPoint(40);
                break;
            case "Spruce":
                scoreManager.AddPoint(50);
                break;
            case "Stone":
                scoreManager.AddPoint(20);
                break;
            case "Stone_1":
                scoreManager.AddPoint(15);
                break;
            case "Stone_3":
                scoreManager.AddPoint(10);
                break;
            case "Stump":
                scoreManager.AddPoint(50);
                break;
            case "Bake":
                scoreManager.AddPoint(50);
                break;
            case "Boat":
                scoreManager.AddPoint(20);
                break;
            case "Box":
                scoreManager.AddPoint(50);
                break;
            case "Chair":
                scoreManager.AddPoint(10);
                break;
            case "Table":
                scoreManager.AddPoint(20);
                break;
            case "Workbench":
                scoreManager.AddPoint(20);
                break;
            case "Firewood":
                scoreManager.AddPoint(50);
                break;
            case "Bed":
                scoreManager.AddPoint(10);
                break;
            case "Bonfire":
                scoreManager.AddPoint(10);
                break;
            default:
                break;
        }
    }
}

