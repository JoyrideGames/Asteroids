using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shoot2
{
    public class Shoot1 : MonoBehaviour
    {

        //Stores the object we want to Instantiate
        public GameObject cannonballPrefab;
        // Speed at which the projectile will be flung
        public float cannonballSpeed = 0f;
        //Rate of fire
        public float shootRate = 0.1f;
        //Timer to count up to shootRate
        private float shootTimer = 0f;
        //Container for RigidBody2D
        private Rigidbody2D rigid2D;
        //Kickback from firing a projectile
        //public float recoil = 30;

        // Use this for initialization
        void Start()
        {
            //Get component from GameObject this script is attached to
            rigid2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            ShootGun();
        }
        void ShootGun()
        {
            if (Input.GetKey(KeyCode.I))
            {
                GameObject cannon = Instantiate(cannonballPrefab);
                cannon.transform.position = transform.position;
                cannon.transform.rotation = transform.rotation;

                Rigidbody2D cannonballz = cannon.GetComponent<Rigidbody2D>();
                cannonballz.AddForce(cannon.transform.forward * cannonballSpeed);
                //rigid2D.AddForce(cannon.transform.forward * cannonballSpeed);
            }
        }
       // Rigidbody rigid = cannon.getcomponent<Rigidbody>();
       // rigid.Addforce(); 
         /*   //Increase Timer
            shootTimer += Time.deltaTime;
            //If R is pressed AND shootTimer >= shootRate
            if (Input.GetKey(KeyCode.R) && shootTimer >= shootRate)
            {
                Shooting();
            }
            //projectile.rigidbody.AddForce(projectile.transform.forward * 10000)

            //shootTimer = 0f;
        }

        void Shooting()
        {
            //Instantiate GameObject here
            GameObject cannon = Instantiate(cannonballPrefab);
            //Position of projectile to Player's position
            cannon.transform.position = transform.position;
            //Addforce
            rigid2D.AddForce(cannon.transform.forward * 10);
            //Apply a recoil
            //rigid2D.AddForce(-transform.right * recoil);
        }*/

    }
}