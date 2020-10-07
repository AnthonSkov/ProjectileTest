using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firepoint : MonoBehaviour
{
    public GameObject bullet;    // this is a reference to your projectile prefab
    public Transform FirePoint; // this is a reference to the transform where the prefab will spawn

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Instantiate(bullet, FirePoint.position, FirePoint.rotation);
        }
    }
}
