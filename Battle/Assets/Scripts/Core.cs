using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    // Start is called before the first frame update
	public float timer;
	public static int B;
	public static int R;
	public static bool playing;

    void Start()
    {
		B=3;
		R=3;
		playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(R != 0 && B != 0) 
		{
			timer += Time.deltaTime;
		}
		else if (playing)
		{
			Debug.Log(timer);
			playing = false;
		}
    }

}
