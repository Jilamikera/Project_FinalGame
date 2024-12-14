using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordsoud : MonoBehaviour
{
    private AudioSource audioSrc;
    [SerializeField]
    private AudioClip sound;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySound()
    {
        audioSrc.PlayOneShot(sound);
    }
    
}
