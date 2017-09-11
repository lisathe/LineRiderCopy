using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour {

    public float scrollSpeed;
    public Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        //Moving horizontally
        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);
        rend.material.mainTextureOffset = offset;
    }
}
