using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private ScoreKeeperScript scorekeeper;
    [SerializeField] private TMP_Text scoreTextP1;
    [SerializeField] private TMP_Text scoreTextP2;
    private int scorePlayerOne = 0;
    private int scorePlayerTwo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scorePlayerOne = scorekeeper.ScorePlayerOne;
        scoreTextP1.SetText("P1 Score: " + scorePlayerOne);
        scorePlayerTwo = scorekeeper.ScorePlayerTwo;
        scoreTextP2.SetText("P2 Score: " + scorePlayerTwo);
    }
}
