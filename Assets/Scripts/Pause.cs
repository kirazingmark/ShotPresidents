using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject pauseButton, pausePanel;
    public AudioSource music;
    //public int scene = SceneManager.GetActiveScene().buildIndex;
    //public PlayVideo playVideo;

    //public void Awake () {
    //    playVideo = new PlayVideo();
    //}

    // Use this for initialization
    public void Start () {
        OnUnPause();
	}

    //// Update is called once per frame
    //void Update () {

    //}

    public void OnPause()
    {
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
        music.Pause();
        //playVideo.OnPause();
        Time.timeScale = 0;
    }

    public void OnUnPause()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
        music.Play();
        //playVideo.OnUnPause();
        Time.timeScale = 1;
    }

    public void OnClick()
    {
        Application.OpenURL("https://soundcloud.com/hesherhenderson/psa-siri-knowsv3-wip/s-DvQAN");
    
    }

    /*public void OnRestartClick()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Time.timeScale = 1;
    }*/
}
