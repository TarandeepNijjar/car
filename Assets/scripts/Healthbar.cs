using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour {

    [SerializeField]
    GameObject mExplosionPrefab;
    [SerializeField]
    GameObject mCollisionPrefab;
    public Image HealthBar;
    public float Healthy = 1;
    AudioSource damage;

    bool startSceneTimer = false;
    float timer = .5f;

    void Start()
    {

        damage = GetComponents<AudioSource>()[0];


    }


    void Update()
    {

        HealthBar.fillAmount = Healthy;
        if (Healthy <= 0f)
        {
            Debug.Log("Hit");


            
            Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);
            startSceneTimer = true;

        }
        if (startSceneTimer)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            Debug.Log("ChangedScene");
            SceneManager.LoadScene("gameover");
            Destroy(gameObject);
        }
    }



    void TakeDamage(int damage)
    {
        Debug.Log("Taking Damage: " + damage);
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.layer == LayerMask.NameToLayer("obstacle"))
        {
            damage.Play();  
            Healthy -= .40f;
            
            Instantiate(mCollisionPrefab, transform.position, Quaternion.identity);
            Destroy(obj.gameObject, 1);

        }

    }
}