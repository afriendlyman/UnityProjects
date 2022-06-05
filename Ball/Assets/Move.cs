using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
	private float timer;
	
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
        transform.position = transform.position + new Vector3(0, 0, -Core.speed * Time.deltaTime);
		if (transform.position.z < -28f) 
		{
			transform.position = new Vector3(0, 0, -4);
		}
    }
}
