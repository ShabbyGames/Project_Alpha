using UnityEngine;
using System.Collections;

public class ScoreUpdater : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        guiText.text = "Score: " + gameData.ScoreStat.Score;
    }
}
