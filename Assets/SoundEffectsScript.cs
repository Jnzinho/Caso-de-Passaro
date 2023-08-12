using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsScript : MonoBehaviour
{
    public AudioSource jumpSound;
    public AudioSource deathSound;
    public void playJumpSound () {
        jumpSound.Play();
    }

    public void playDeathSound () {
        deathSound.Play();
    }
}
