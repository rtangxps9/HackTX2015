using UnityEngine;
using System.Collections;

public class AsteroidScript : MonoBehaviour {
	Rigidbody body;
	public Vector3 vel = new Vector3(0, 0, -10);
	// Use this for initialization
	void Start ()
	{
		body = GetComponent<Rigidbody> ();
		body.velocity = vel;
		float x = Random.Range(0f, 3f);
		transform.localScale += new Vector3(x, x, x);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}