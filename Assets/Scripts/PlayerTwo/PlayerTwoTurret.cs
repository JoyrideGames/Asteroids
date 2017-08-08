using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoTurret : MonoBehaviour
{
    private Rigidbody2D playerTwoTurret;
   // public float moveCounter, moveClock;
    //public float rotationTurretSpeed;

    // Use this for initialization
    void Start()
    {
        playerTwoTurret = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        RotationTurret();
    }

    void RotationTurret()
    {
        if (Input.GetKey(KeyCode.U))
        {
            transform.Rotate(0, 0,1);
        }
        if (Input.GetKey(KeyCode.O))
        {
            transform.Rotate(0, 0, -1);
        }
    }
}
