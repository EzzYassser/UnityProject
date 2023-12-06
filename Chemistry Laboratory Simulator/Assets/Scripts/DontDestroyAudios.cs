using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyAudios : MonoBehaviour
{
    private static bool isCreated = false;  // Track if an instance of the script has been created

    private AudioSource music;

    void Awake()
    {
        if (!isCreated)
        {
            DontDestroyOnLoad(gameObject);
            isCreated = true;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

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