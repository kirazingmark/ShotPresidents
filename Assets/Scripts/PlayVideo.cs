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
    }

    void Start() {
        StartCoroutine(WaitToPlay());
    }

    IEnumerator WaitToPlay()
    {
        print(Time.time);
        yield return new WaitForSeconds(58);
        tex.Play();
        print(Time.time);
    }

    void Update () {
        tex.Update();
    }
}