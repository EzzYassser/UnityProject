using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyAudios : MonoBehaviour
{
    private AudioSource music;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        music = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            music.enabled = false; // Deactivate the music
        }
        else
        {
            music.enabled = true; // Activate the music
        }
    }
}