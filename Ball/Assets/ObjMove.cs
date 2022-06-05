using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
	public ParticleSystem stars;
	private float timer;
	private Transform magnet;
	
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
        transform.position = transform.position + new Vector3(0, 0, -Core.speed * Time.deltaTime);
		if (transform.position.z < -50f) 
		{
			transform.position = new Vector3(Random.Range(-5f + transform.lossyScale.z, 5f - transform.lossyScale.z), 0.6f, 5f);
		}
    }
	
	private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("Ball"))
		{
			if (!Core.turbo)
			{
				CreateStars();
				transform.position = new Vector3(0, 0, -34f);
				Core.points ++;
			}
			
		}

    }
	
	void CreateStars(){
		stars.Play();
	}
	
		
}