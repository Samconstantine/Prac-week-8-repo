using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeperScript : MonoBehaviour
{
    [SerializeField] private int points;
    private int scorePlayerOne;
    public int ScorePlayerOne
    {
        get
        {
            return scorePlayerOne;
        }
    }
    private int scorePlayerTwo;
    public int ScorePlayerTwo
    {
        get
        {
            return scorePlayerTwo;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        scorePlayerOne = 5;
        scorePlayerTwo = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreasePoints() {
        //find way to determine which player
        scorePlayerOne += points;
        scorePlayerTwo += points;
    }
}
