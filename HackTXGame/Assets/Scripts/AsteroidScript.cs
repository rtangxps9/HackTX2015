using UnityEngine;
using System.Collections;

public class AsteroidScript : MonoBehaviour {
	Rigidbody body;
	public Vector3 vel = new Vector3(0, 0, -15);
	// Use this for initialization
	void Start ()
	{
		body = GetComponent<Rigidbody> ();

		float x = Random.Range(1f, 5f);
		float y = Random.Range(1f, 5f);
		float z = Random.Range(1f, 5f);
		body.velocity = vel;
		transform.localScale += new Vector3(x, y, z);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}