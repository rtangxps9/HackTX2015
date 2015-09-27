using UnityEngine;
using System.Collections;

public class WorldScript : MonoBehaviour {
	Vector3 startPoint;
	public GameObject asteroid;
	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("CreateAsteroid", 1f, 1.5f); //Manipulate last two parameters depending on desired spawn rate 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void CreateAsteroid()
	{
		float x = Random.Range(-8.5f, 10.5f);
		float y = Random.Range(-9f, 12f);
		
		startPoint = new Vector3(x, y, 40);
		Instantiate(asteroid, startPoint, Quaternion.identity);
	}
	
}