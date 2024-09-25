using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketsBehaviour : MonoBehaviour {
    public float movementSpeed;
   // Rigidbody2D myRigidbody;
    // Use this for initialization
    void Start () {
        //myRigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float moveVertical = Input.GetAxis("Vertical");
        /*Vector2 movement = new Vector2(0, moveVertical);
        myRigidbody.AddForce(movement); */
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveVertical) * movementSpeed;
    }
}
