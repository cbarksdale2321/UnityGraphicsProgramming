using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour {
    public float speed = 5f;

    Vector3 temp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        temp = transform.localScale;

        temp.x += Time.deltaTime;

        transform.localScale = temp;
	}
}
