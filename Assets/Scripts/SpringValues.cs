using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpringValues : MonoBehaviour {

	public Text currentSpringSize;
	public Slider size;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		currentSpringSize.text = size.value.ToString ();
	}
}
