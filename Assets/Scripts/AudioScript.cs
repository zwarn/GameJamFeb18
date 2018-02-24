using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private bool wasJumping = false;
    private bool wasAlive = false;
    private Animator animator;
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {
        MusicSource.clip = MusicClip;


    }

    // Update is called once per frame
    void Update()
    {
   

        if (animator.GetBool("isJumping") && !wasJumping)
        {
            MusicSource.Play();
            Debug.Log("jump");
        }

  
        wasJumping = animator.GetBool("isJumping");
        wasAlive = animator.GetBool("isAlive");
    }
}
