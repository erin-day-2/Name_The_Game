using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed;
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))       
            {transform.Translate(0, 0 , speed * Time.deltaTime);}

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))     
            {transform.Translate(0, 0 , -speed * Time.deltaTime);}

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))     
            {transform.Translate(-speed * Time.deltaTime, 0, 0);}

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))    
            {transform.Translate(speed * Time.deltaTime, 0, 0);}


        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);
    }
}
