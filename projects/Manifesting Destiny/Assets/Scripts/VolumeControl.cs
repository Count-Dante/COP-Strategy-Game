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
        audioMixer.SetFloat("music", music_volume);
    }

    public void GameSoundsVolume(float game_sounds_volume)
    {
        Debug.Log(game_sounds_volume);
        audioMixer.SetFloat("game_sounds", game_sounds_volume);
    }
}

