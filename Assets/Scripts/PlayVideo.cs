using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class PlayVideo : MonoBehaviour {

    WebGLMovieTexture tex;
    public string videoPath;

    void Awake () {
        tex = new WebGLMovieTexture(videoPath);
        gameObject.GetComponent<MeshRenderer>().material.mainTexture = tex;
        tex.Play();
    }

    void Update () {
        tex.Update();
    }
}