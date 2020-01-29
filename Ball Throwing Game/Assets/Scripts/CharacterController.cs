using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CharacterController : MonoBehaviour
{
    public BulletCount bulletCountManager;
    public float speed = 25.0f;
    public float rotationSpeed = 90;
    public float force = 700f;
    public GameObject cannon;
    public GameObject bullet;
 
    Rigidbody rb;
    Transform t;

    int bulletCount;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
        bulletCount = 10;
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rb.velocity += this.transform.forward * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            rb.velocity -= this.transform.forward * speed * Time.deltaTime;
 
        if (Input.GetKey(KeyCode.D))
            t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.A))
            t.rotation *= Quaternion.Euler(0, - rotationSpeed * Time.deltaTime, 0);
       
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(t.up * force);
 
        if (Input.GetKeyDown(KeyCode.RightControl) || Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.Mouse1)){
            if(bulletCount == 0){
                bulletCountManager.MinusBullet(bulletCount);
                print("Zero Ball Left");
            }else{
                GameObject newBullet = GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
                newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 2;
                newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1500);
                bulletCount--;
                bulletCountManager.MinusBullet(bulletCount);
                print(bulletCount + " Left");

            }
            
        }
    }
}