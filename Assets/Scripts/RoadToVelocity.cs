using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tanks
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class RoadToVelocity : MonoBehaviour
    {
        private Rigidbody2D ballBone;

        // Use this for initialization
        void Start()
        {
            ballBone = GetComponent<Rigidbody2D>();

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 vel = ballBone.velocity;
            float angle = Mathf.Atan2(vel.y, vel.x);
            ballBone.rotation = angle * Mathf.Rad2Deg;
        }
    }

}