using UnityEngine;
using DialogueEditor;

public class Conversationstarterr : MonoBehaviour
{
    [SerializeField] private NPCConversation firstConversation;
    [SerializeField] private NPCConversation secondConversation;

    private int conversationIndex = 0; // 0 = first convo, 1 = second convo
    private bool isTalking = false;
    private bool playerInTrigger = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
    Debug.Log("Something entered");

    if (other.CompareTag("Player"))
    {
        Debug.Log("Player entered");
        playerInTrigger = true;
    }
}

    private void Update()
    { 
        if (playerInTrigger && Input.GetKeyDown(KeyCode.E) && !isTalking)
        {
            NPCConversation conversationToStart = null;

            if (conversationIndex == 0)
                conversationToStart = firstConversation;
            else if (conversationIndex == 1)
                conversationToStart = secondConversation;
    

            if (conversationToStart != null)
            {
                ConversationManager.Instance.StartConversation(conversationToStart);
                isTalking = true;
            }
        }
        if (isTalking && !ConversationManager.Instance.IsConversationActive)
        {
            isTalking = false;
            conversationIndex++; // switches the conversations!!
        }
    }
}
