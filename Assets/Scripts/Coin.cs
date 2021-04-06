using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("Sound Effects")]
    [SerializeField] AudioClip pickUpSound;
    [SerializeField] [Range(0, 1)] float pickUpSoundVolume = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            FindObjectOfType<GameSession>().AddToScore(1);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(pickUpSound, Camera.main.transform.position, pickUpSoundVolume);
        }
    }
}
