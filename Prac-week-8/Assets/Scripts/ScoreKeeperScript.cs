using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeperScript : MonoBehaviour
{
    [SerializeField] private int points;
    private int score;
    public int Score
    {
        get
        {
            return score;
        }
        set 
        {
            score = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreasePoints() {
        score += points;
    }
}
