using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DialogueEditor;

public class TestScript : MonoBehaviour {

    public Button startButton;
    private NPCConversation conversation;

    void Start() {
        startButton.onClick.AddListener(StartConversation);
        conversation = GetComponent<NPCConversation>();
    }
    
    void StartConversation() {
        Debug.Log("Start conversation");
        ConversationManager.Instance.StartConversation(conversation);
        startButton.gameObject.SetActive(false);
    }

    public void KillWizard() {
        Debug.Log("wizard now ded");
    }

}
