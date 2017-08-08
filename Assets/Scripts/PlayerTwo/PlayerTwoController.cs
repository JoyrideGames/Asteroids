using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoController : MonoBehaviour {

    public float speed;
    public float deceleration;
    public float rotation;
    private Rigidbody2D playerTwo;

	// Use this for initialization
	void Start () {
        playerTwo = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        Speed();
        Deceleration();
        Rotation();

	}

    void Speed ()
    {
        float moveVertical = Input.GetAxis("P2Vertical");
        playerTwo.AddForce(transform.right * moveVertical * speed);

    }

    void Rotation()
    {
        float moveVertical = Input.GetAxis("P2Vertical");
        float moveHorizontal = Input.GetAxis("P2Horizontal");
        

       // playerOne.AddTorque(-moveHorizontal * rotation * Time.deltaTime * moveVertical);
       
        transform.rotation *= Quaternion.AngleAxis(moveHorizontal * rotation * Time.deltaTime, Vector3.back * moveVertical);
    }

    void Deceleration()
    {
        playerTwo.velocity += -playerTwo.velocity * deceleration * Time.deltaTime;
        //playerOne.rotation += playerOne.rotation * -despin * Time.deltaTime;
    }

}
