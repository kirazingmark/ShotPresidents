using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public float blockSpeed = 2f;
    public int index;

    void Awake () {
        index = PlayerPrefs.GetInt("Character"); // 0 = AWOL, 1 = HESHER, 2 = JIGGY MIGGY
        print(index);

        instance = this;
	}
	
	void Update () {
		
	}
}
