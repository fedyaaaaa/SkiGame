using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private KeyCode leftInput, rightInput;
    [SerializeField] private float acceleration = 100, turnSpeed = 100,minSpeed =0,  maxSpeed = 500;
    
    
    private float speed = 0;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        speed += acceleration * Time.fixedDeltaTime;
        speed = Mathf.Clamp(speed, minSpeed, maxSpeed);
        Vector3 velocity = transform.forward * speed * Time.fixedDeltaTime;
        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.z);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftInput) && transform.eulerAngles.y <269)
        {
            transform.Rotate(new Vector3(0, turnSpeed*Time.deltaTime,0),Space.Self);
        }

        if (Input.GetKey(rightInput) && transform.eulerAngles.y > 91)
        {
            transform.Rotate(new Vector3(0, -turnSpeed*Time.deltaTime,0),Space.Self);
        }
        
    }
}
