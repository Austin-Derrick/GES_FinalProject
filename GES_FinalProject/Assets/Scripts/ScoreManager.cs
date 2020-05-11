using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<MonoBehaviour>
{
    public int score { get; private set; }


    public void incrementScore(int increment = 1)
    {
        score += increment;
    }
}
