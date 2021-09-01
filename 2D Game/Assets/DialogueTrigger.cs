using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public bool inDialogue = false;

    public void TriggerDialogue()
    {
        if (!inDialogue)
        {
            inDialogue = true;
            DialogueManager.Instance.StartDialogue(dialogue);
        }
        else
        {
            DialogueManager.Instance.DisplayNextSentence();
        }
    }
}
