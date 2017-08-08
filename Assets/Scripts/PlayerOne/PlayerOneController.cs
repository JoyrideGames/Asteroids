using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneController : MonoBehaviour {

    public float speed;
    public float deceleration;
    public float rotation;
    private Rigidbody2D playerOne;

	// Use this for initialization
	void Start () {
        playerOne = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        Speed();
        Deceleration();
        Rotation();

	}

    void Speed ()
    {
        float moveVertical = Input.GetAxis("Vertical");
        playerOne.AddForce(transform.right * moveVertical * speed);

    }

    void Rotation()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        

       // playerOne.AddTorque(-moveHorizontal * rotation * Time.deltaTime * moveVertical);
       
        transform.rotation *= Quaternion.AngleAxis(moveHorizontal * rotation * Time.deltaTime, Vector3.back * moveVertical);
    }

    void Deceleration()
    {
        playerOne.velocity += -playerOne.velocity * deceleration * Time.deltaTime;
        //playerOne.rotation += playerOne.rotation * -despin * Time.deltaTime;
    }

}
