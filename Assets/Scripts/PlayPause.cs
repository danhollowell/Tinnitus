using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPause : MonoBehaviour {
    public AudioSource source;

    public void TogglePlay()
    {
        if (source.isPlaying)
        {
            source.Stop();
        }
        else
        {
            source.Play();
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
