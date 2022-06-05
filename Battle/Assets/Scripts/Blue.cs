using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : warriors
{
    // Start is called before the first frame update
	private float Firerate;
	public GameObject Bullet;
	public static Transform target;
    void Start()
    {
		//определяем скорострельность
		Damage = 1f - 0.1f*Damage;
		//находим противника
        target = GameObject.FindGameObjectWithTag("Red").transform;
		Firerate = Damage;
    }

    // Update is called once per frame
    void Update()
    {
		
		//Движение в сторону цели
		if (GameObject.FindGameObjectWithTag("Red") != null)
		{
			target = GameObject.FindGameObjectWithTag("Red").transform;
			if ((Vector2.Distance(transform.position, target.position) > Range) && (target != null))
			{
				transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
			}
			else
			{
				transform.position = this.transform.position;
					//Стрельба по цели если боец подошел достаточно близко
				if (Firerate <= 0)
				{
					Instantiate(Bullet, transform.position, Quaternion.identity);
					Firerate = Damage;
				}
				else
				{
					Firerate -= Time.deltaTime;
				}
				
			}
		}		
		
		if (HP <=0)
		{
			Destroy(gameObject);
			Core.B -= 1;
			
		}
    }
	
	private void OnTriggerEnter2D(Collider2D bullet)
	{
		if (bullet.tag == "RedBullet")
        {
			HP -= 1;
		}	
			
	}
}