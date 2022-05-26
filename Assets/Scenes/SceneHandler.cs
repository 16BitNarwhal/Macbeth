using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{

    static Stack<string> sceneHistory = new Stack<string>();

    void Start() {
        Camera.main.backgroundColor = Color.black;
    }
    
    public void LoadScene(string sceneName)
    {
        sceneHistory.Push(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void LoadPreviousScene()
    {
        if (sceneHistory.Count >= 1) {
            SceneManager.LoadScene(sceneHistory.Peek());
        }
    }

}
