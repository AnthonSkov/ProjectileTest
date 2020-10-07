using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed;
    public float rotatespeed;
    


    // Start is called before the first frame update
    void Start()
    {
        movespeed = 25f;
        rotatespeed = 120f;
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("Horizontal"));
        transform.Translate(movespeed*Input.GetAxis("Horizontal") * Time.deltaTime,0f, movespeed*Input.GetAxis("Vertical") * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.up * rotatespeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(-Vector3.up * rotatespeed * Time.deltaTime);
    }

    

}
