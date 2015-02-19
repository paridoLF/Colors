using UnityEngine;
using System.Collections;
using Meta;

public class cubeBehaviour : MetaBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onActivate()
	{
		renderer.material.color = Color.red;
	}
}
