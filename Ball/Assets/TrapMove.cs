using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMove : MonoBehaviour
{
	private float timer;
	private int respawn;
	public ParticleSystem damage;
	
    void Start()
    {
		respawn = -36;
    }

    void Update()
    {
		timer += Time.deltaTime;
        transform.position = transform.position + new Vector3(0, 0, -Core.speed * Time.deltaTime);
		if (transform.position.z < (float)respawn) 
		{
			transform.position = new Vector3(Random.Range(-5f + transform.lossyScale.x/2.5f, 5f - transform.lossyScale.x/2.5f), 0.6f, 0f);
			transform.rotation = Quaternion.Euler(0, Random.Range(0f, 270f), 0);
			respawn = Random.Range(-41, -36);
		}
    }
	
	private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("Ball"))
		{   if (Core.turbo)
			{
				CreateDamage();
				transform.position = new Vector3(0, 0, -35f);
				Core.points ++;
			}
			else
			{
				CreateDamage();
				transform.position = new Vector3(0, 0, -35f);
				Core.HP --;
			}
		}

    }
	
	void CreateDamage(){
		damage.Play();
	}
}
