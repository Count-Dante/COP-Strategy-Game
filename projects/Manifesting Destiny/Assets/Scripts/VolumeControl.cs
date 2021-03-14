using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeControl : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void MusicVolume(float music_volume)
    {
        Debug.Log(music_volume);
        audioMixer.SetFloat("music", (Mathf.Log10(music_volume) * 20));
    }

    public void GameSoundsVolume(float game_sounds_volume)
    {
        Debug.Log(game_sounds_volume);
        audioMixer.SetFloat("game_sounds", (Mathf.Log10(game_sounds_volume) * 20));
    }
}

