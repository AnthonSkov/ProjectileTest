using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class F2 : MonoBehaviour
{

    public GameObject bulleto;    // this is a reference to your projectile prefab
    public Transform FirePoint; // this is a reference to the transform where the prefab will spawn

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulleto, FirePoint.position, FirePoint.rotation);
        }
    }
}