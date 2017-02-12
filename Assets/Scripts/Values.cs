using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Values : MonoBehaviour {

	public Text currentMass;
	public Slider weight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentMass.text = weight.value.ToString ();
	}
}
