using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 100.0f;
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.position += new Vector3(horizontal, vertical, 0);
    }
   
}
