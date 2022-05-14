using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ScoreHandler : MonoBehaviour {

    static Dictionary<string, int> scores = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start() {
        // find dialogue manager
        scores.Add("evil", 0);
    }

    public static Dictionary<string, int> getScores() {
        return scores;
    }

    public static int getScore(string scoreName, int scoreVal) {
        return scores[scoreName];
    }

    public static void setScore(string scoreName, int newScoreVal) {
        scores[scoreName] = newScoreVal;
    }

}
