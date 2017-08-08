using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed;
    
void Start()
    {
        Rigidbody2D rigid2D = GetComponent<Rigidbody2D>();
        rigid2D.velocity = transform.up * speed;
    }

    }