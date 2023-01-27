using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 
    }
    
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(verticalInput, 0.0f, horizontalInput);
        transform.position += movement * speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += movement * (speed * 2) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            transform.position += movement * (speed * 2) * Time.deltaTime;
        }
    }
}
