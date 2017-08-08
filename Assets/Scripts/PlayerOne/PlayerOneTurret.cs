using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneTurret : MonoBehaviour
{
    private Rigidbody2D playerOneTurret;
   // public float moveCounter, moveClock;
    //public float rotationTurretSpeed;

    // Use this for initialization
    void Start()
    {
        playerOneTurret = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        RotationTurret();
    }

    void RotationTurret()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, 0,1);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(0, 0, -1);
        }
    }
}
