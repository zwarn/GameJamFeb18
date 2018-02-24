using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour {

    private Animator animator;
    public AudioClip MusicClipBGMusic;
    public AudioSource MusicSourceBGMusic;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {
        MusicSourceBGMusic.clip = MusicClipBGMusic;

        MusicSourceBGMusic.Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
