using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private ScoreKeeperScript scorekeeper;
    [SerializeField] private TMP_Text scoreText;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = scorekeeper.Score;
        scoreText.SetText("Score: " + score);
    }
}
