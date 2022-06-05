using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraTrap : MonoBehaviour
{
    // Start is called before the first frame update
	public static float speed;
	private float timer;
	
    void Start()
    {
		speed = 6f;
    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
        transform.position = transform.position + new Vector3(0, 0, -speed * Time.deltaTime);
		if (transform.position.z < -50f) 
		{
			transform.position = new Vector3(Random.Range(-5f + transform.lossyScale.x/2f, 5f - transform.lossyScale.x/2f), 1f, 0f);
			//transform.rotation = new Quaternion(0f, Random.Range(1f, 270f), 0f);
			//Quaternion target = Quaternion.Euler(0, Random.Range(0f, 270f), 0);
			//transform.rotation = Quaternion.Slerp(transform.rotation, target,  0);
			transform.rotation = Quaternion.Euler(0, Random.Range(0f, 270f), 0);
		}
    }
}
