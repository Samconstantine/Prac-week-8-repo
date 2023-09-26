using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] ScoreKeeper scoreKeeper;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider collider)
    {
        scoreKeeper.IncreasePoints();
        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}