using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	public float speed;
	
	Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		float moveH = Input.GetAxis("Horizontal");
		float moveV = Input.GetAxis("Vertical");
		if (Input.GetMouseButtonDown(0))
		Debug.Log("Press");
				Vector3 movement = new Vector3(moveH*speed, rb.velocity.y, 0);
				rb.AddForce(movement);
    }
}

