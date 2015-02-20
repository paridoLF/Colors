using UnityEngine;
using System.Collections;

public class colorScript : MonoBehaviour {

	public void paint()
	{
		Color randomColor = new Color (Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), 1.0f);
		renderer.material.color = randomColor;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
