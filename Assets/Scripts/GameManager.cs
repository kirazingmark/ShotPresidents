using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public float blockSpeed = 2f;
    
	void Awake () {
        instance = this;
	}
	
	void Update () {
		
	}
}
