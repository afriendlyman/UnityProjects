using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Core : MonoBehaviour
{
	private float timer;
	private float holdspeed;
	public static float speed;
	public static int points;
	public static int HP;
	public static bool turbo;
	private bool increasing;
	
	
	public GameObject Heart1;
	public GameObject Heart2;
	public GameObject Heart3;
	public TextMeshProUGUI pointsText;
	public TextMeshProUGUI timerText;
	public GameObject StartPause;
	public GameObject ResumePause;
	public GameObject RestartPause;
	public ParticleSystem Turbo;
	
    // Start is called before the first frame update
    void Start()
    {
		timer = 15f;
		turbo = false;
		Time.timeScale = 0; 
        speed = 6f;
		holdspeed = speed;
		points = 0;
		HP = 3;
		//increasing = false;
    }

    // Update is called once per frame
    void Update()
    {	
		pointsText.text = points.ToString();
		
		
		if (HP == 0)
			{
				ResumePause.SetActive(true);
				Time.timeScale = 0; 	
				HP = -1;				
			}	
			
			
		if (turbo)
			{
				timer -= Time.deltaTime * 0.5f;
				timerText.text = timer.ToString();
				if (timer <= 0)	
				{
					timer = 0;
					RestartPause.SetActive(true);
					Time.timeScale = 0;
				}
			}
			
			
		else if ((points >= 10) && (points <= 20) && (speed <= holdspeed*1.5f))
			{
				speed += Time.deltaTime * 0.5f;
			}
		else if ((points >= 20) && (points <= 50) && (speed <= holdspeed*2f))
			{
				//increasing = true;
				speed += Time.deltaTime * 0.5f;
			}
		else if ((points >= 50) && (points <= 100) && (speed <= holdspeed*3f))
			{
				//increasing = true;
				speed += Time.deltaTime * 0.5f;
			}
		else if ((points >= 100) && (speed <= holdspeed*4f))
			{
				//increasing = true;
				speed += Time.deltaTime * 0.5f;
			}
		
		switch(HP)
        {
            case 3:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;

            case 2:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(false);
                break;

            case 1:
                Heart1.SetActive(true);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;

            case 0:
                Heart1.SetActive(false);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;
        }
		
		
    }
	
	public void Start_Button()
	{
		Time.timeScale = 1;
		StartPause.SetActive(false);	
	}
	public void Resume_Button()
	{	
		Time.timeScale = 1;
		turbo = true;
		Turbo.Play();
		speed = holdspeed*4.5f; 
		ResumePause.SetActive(false);
	}
	public void Restart_Button()
	{
		SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
	}
	

	
}


	
