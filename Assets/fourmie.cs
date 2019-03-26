using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fourmie : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0){ Debug.Log("Axis Val =" + Input.GetAxis("Horizontal")); }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 1.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}
