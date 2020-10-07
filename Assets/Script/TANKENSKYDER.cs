using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TANKENSKYDER : MonoBehaviour
{

    public GameObject projectile;
    public float movementspeed = 1000f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;

            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10 * movementspeed);

        }
    }
}
