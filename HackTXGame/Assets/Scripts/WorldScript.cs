using UnityEngine;
using System.Collections;

public class WorldScript : MonoBehaviour {
	Vector3 startPoint;
	public GameObject asteroid;
	public GameObject score;
	GUIText gText; // drag here the GUIText from Hierarchy view
	public GameObject hscore;
	GUIText hgText; // drag here the GUIText from Hierarchy view
	float timer = 0;
	GUIText iText; // drag here the GUIText from Hierarchy view
	public GameObject instr;
	float hScore;
	// Use this for initialization
	void Start ()
	{
		hScore = PlayerPrefs.GetFloat ("highscore");
		gText = score.GetComponent<GUIText> ();
		hgText = hscore.GetComponent<GUIText> ();
		InvokeRepeating("CreateAsteroid", 1f, .3f); //Manipulate last two parameters depending on desired spawn rate 
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer < 0) 
		{
			timer = 0; // clamp the timer to zero
		}

		if(timer > hScore)
		{
			PlayerPrefs.SetFloat("highscore", timer);
		}
		int seconds = (int)timer % 60; // calculate the seconds
		int minutes = (int)timer / 60; // calculate the minutes
		gText.text = "Score: " + minutes + ":" + seconds;
		seconds = (int)hScore % 60; // calculate the seconds
		minutes = (int)hScore / 60; // calculate the minutes
		hgText.text = "High Score: " + minutes + ":" + seconds;
	}
	
	void CreateAsteroid()
	{
		float x = Random.Range(-14f, 15f);
		float y = Random.Range(-7f, 11f);
		
		startPoint = new Vector3(x, y, 40);
		Instantiate(asteroid, startPoint, Quaternion.identity);
	}
	
}