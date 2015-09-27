using UnityEngine;
using System.Collections;

public class BoundaryScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*
	void OnCollisionEnter(Collision collision)
	{
		GameObject target = collision.gameObject;
		Debug.Log (target.name);
		//Debug.Log ("ASLKFJASLKFHASFLKF");
	}
	*/
	void OnCollisionExit(Collision collisionInfo)
	{
		GameObject target = collisionInfo.gameObject;
		Debug.Log (target.name);
		if (target.name == "Asteroid(Clone)") 
		{
			Destroy(target);
		}

	}
}
