using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinDisplay : MonoBehaviour
{
    TMP_Text coinText;
    GameSession gameSession;

    // Use this for initialization
    void Start()
    {
        coinText = GetComponent<TMP_Text>();
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = gameSession.GetScore().ToString();
    }
}
