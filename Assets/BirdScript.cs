using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BirdScript : MonoBehaviour
{
    public SoundEffectsScript soundEffectPlayer;
    public Rigidbody2D myRigidbody;
    public float velocidade;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
        myRigidbody.velocity = Vector2.up * velocidade;
        soundEffectPlayer.playJumpSound();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver();
        birdIsAlive = false;
    }
}
