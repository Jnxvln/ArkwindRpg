using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TestRoomBackgroundMusic : MonoBehaviour
{

    public AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("Background music started.");
    }

    void Update()
    {
        if (audioData != null)
        {
             audioData = GetComponent<AudioSource>();
        }
    }
}
