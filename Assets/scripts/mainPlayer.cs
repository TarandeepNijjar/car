using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject mExplosionPrefab;
    [SerializeField]
    GameObject mCollisionPrefab;
    public float MovementSpeed = 1;
    public float SpeedUp = 0.5f;
    Rigidbody2D myRigidBody2D;
    
    public AudioSource enginesound;
    public AudioSource explosionsound;
    



    // Use this for initialization
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        
        enginesound = GetComponents<AudioSource>()[0];
        explosionsound = GetComponents<AudioSource>()[0];
        
    }

    // Update is called once per frame

    void Update()
    {
        

            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");


            if (transform.position.x >= -1.76 && transform.position.x <= 1.99)
            {

                transform.position += new Vector3(horizontal, 0, 0) * Time.deltaTime * MovementSpeed;
            }

            if (transform.position.x <= -1.76)
            {
                transform.position = new Vector3(-1.75f, transform.position.y, transform.position.z);
            }
            if (transform.position.x >= 1.9)
            {
                transform.position = new Vector3(1.899f, transform.position.y, transform.position.z);
            }

            if (transform.position.y >= 160)
            {
                transform.position = new Vector3(transform.position.x, -19, transform.position.z);
            }



            //transform.position += new Vector3(0, vertical, 0) * Time.deltaTime * MovementSpeed;

            //Velocity Control
            if (vertical > 0)
            {
                
                SpeedUp++;
            }
            else if (vertical < 0 && SpeedUp != 0)
            {

                SpeedUp--;
            }






            myRigidBody2D.velocity = Vector2.up * (SpeedUp - (SpeedUp / 2));
        }

        
    

    

   
    }
