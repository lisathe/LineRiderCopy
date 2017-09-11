using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

    public GameObject lineObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (Input.GetMouseButtonDown(0))
        {
            //  Vector3 _objectPos = Camera.current.ScreenToWorldPoint(Input.mousePosition);
            Vector3 _objectPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Ray ray = Camera.main.ScreenP
            Instantiate(lineObj, _objectPos, Quaternion.identity);
            

        }

		
	}
}
