using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    float posX;
    float posY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       posX =  Input.mousePosition.x;
       posY = Input.mousePosition.y;
    }
    void OnMouseDrag()
    {
         transform.position = Camera.main.ScreenToWorldPoint(new Vector3(posX, posY, 10.0f));
    }
}
