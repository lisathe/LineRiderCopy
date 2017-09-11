using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

    public GameObject lineObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      //  if (Input.GetMouseButtonDown(0))
      if(Input.anyKey)
        {
            //  Vector3 _objectPos = Camera.current.ScreenToWorldPoint(Input.mousePosition);
            Vector3 _objectPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(lineObj, new Vector3(_objectPos.x, _objectPos.y, _objectPos.z+1), Quaternion.Euler(0,180,0));

        }

		
	} 
}
