using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour {
    [SerializeField]

    public Text ScoreText;

    static int score = 0;
    public GameObject player;
    AudioSource coin;
    SpriteRenderer mySprite;


    void Start()
    {
        coin = GetComponent<AudioSource>();
        mySprite = GetComponent<SpriteRenderer>();
    }


    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            coin.Play();
            mySprite.enabled = false;
            Destroy(gameObject, .2f);
            score++;
            ScoreText.text = "Scores: " + score;
        } 
    } 
}
