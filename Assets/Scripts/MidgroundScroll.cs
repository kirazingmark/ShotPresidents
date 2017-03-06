using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidgroundScroll : MonoBehaviour {

    public float speed;
    Renderer myRenderer;

    void Start () {
        myRenderer = GetComponent<Renderer>();
    }

    void FixedUpdate () {
        myRenderer.material.mainTextureOffset += Vector2.right * speed * Time.fixedDeltaTime;
    }
}
