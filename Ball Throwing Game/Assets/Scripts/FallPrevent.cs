using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FallPrevent : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag == "Friendly")
        {
            print("Running on the plane");            
        }else if(collision.gameObject.tag == "Finish"){
            print("Hitting targets");
        }else{
            print("fell from the ground");
        }
    }
}
