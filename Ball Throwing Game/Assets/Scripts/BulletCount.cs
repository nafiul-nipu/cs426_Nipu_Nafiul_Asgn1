using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BulletCount : MonoBehaviour
{
    public Text bullet;
    public int maxBullet = 10;
 
    // Start is called before the first frame update
    void Start()
    {
        bullet.text = "Balls Left: " + maxBullet;
        // print("start point" + total_score);
    }
   
    public void MinusBullet(int bullets)
    {
              
        bullet.text = "Balls Left: " + bullets;
    }
}
