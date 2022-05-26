using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ScoreHandler : MonoBehaviour {

    static Dictionary<string, int> scores = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start() {
        addKey("killed guards", 0); 
        addKey("killed banquo", 0);
        addKey("killed lady macduff", 0);
        addKey("killed macduff", 0); // macbeth killed macduff in final battle
        addKey("killed macbeth", 0); // macduff killed macbeth in final battle
    }

    private void addKey(string key, int value) {
        if (!scores.ContainsKey(key)) {
            scores.Add(key, value);
        }
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
