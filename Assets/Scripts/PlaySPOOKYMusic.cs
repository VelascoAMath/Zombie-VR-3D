using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySPOOKYMusic : MonoBehaviour {
    public AudioClip music;
    private AudioSource source;
    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        source.loop = true;
        source.PlayOneShot(music);
        source.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
