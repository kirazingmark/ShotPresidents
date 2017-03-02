using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour {

    float speed;
    Transform myTransform;
    
	void Start () {
        speed = GameManager.instance.blockSpeed;
        myTransform = transform;
	}
	
	void FixedUpdate () {
        myTransform.localPosition += Vector3.left * speed * Time.fixedDeltaTime;
	}
}
