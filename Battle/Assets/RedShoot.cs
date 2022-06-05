using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShoot : MonoBehaviour
{
    // Start is called before the first frame update
	private Transform target;
	public float speed;
	
    void Start()
    {
		if ((target == null)&&(Red.target != null))
		{
			target = Red.target;
		}
    }

    // Update is called once per frame
    void Update()
    {
		CheckTarget();
		if ((target != null)&&(Red.target != null))
		{
			transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
			
			if (transform.position.x == target.position.x && transform.position.y == target.position.y)
				{
					Destroy(gameObject);
				}
		}
    }
		
	private void CheckTarget()
	{
		if ((target == null)||(Red.target == null))
		Destroy(gameObject);
	}

}
