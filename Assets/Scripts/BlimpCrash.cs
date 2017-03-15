using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlimpCrash : MonoBehaviour {

    public float crashAngle = 35f;
    public Transform rotationOrigin;
    public float crashTime = 5f;
    public BlimpWobble wobbleScript;

    public Vector3 startPosition;
    public Vector3 finalPosition;
    public float travelTime = 40f;
    Transform myTransform;

    Quaternion crashRot;
    bool isCrashing = false;
    float curTime = 0f;

    public GameObject explosionPrefab;
    bool hasExploded = false;
    public Vector3 explosionPosition;
    public GameObject smokeParticles;

	void Start () {
        crashRot = Quaternion.Euler(Vector3.back * crashAngle);
        myTransform = transform;
	}
	
	void FixedUpdate () {
		if (isCrashing) {
            curTime += Time.deltaTime / crashTime;
            rotationOrigin.rotation = Quaternion.Lerp(Quaternion.identity, crashRot, curTime);
            if (curTime > 1f) {
                myTransform.position += Vector3.down * Time.deltaTime * 1.3f;
                if (!hasExploded) {
                    hasExploded = true;
                    Instantiate(explosionPrefab, explosionPosition, Quaternion.identity);
                }
                if (curTime > 3f) {
                    Destroy(gameObject);
                }
            }
        } else {
            curTime += Time.deltaTime / travelTime;
            myTransform.position = Vector3.Lerp(startPosition, finalPosition, curTime);
            if (curTime >= 1) {
                Crash();
            }
        }
	}

    public void Crash () {
        curTime = 0;
        smokeParticles.SetActive(true);
        isCrashing = true;
        wobbleScript.enabled = false;
    }
}
