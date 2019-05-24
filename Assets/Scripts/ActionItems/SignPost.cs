using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignPost : ActionItem
{
    [SerializeField]
    private string[] dialogue;
    [SerializeField]
    private string signName;

    public override void Interact()
    {
        base.Interact();
        DialogueSystem.Instance.AddNewDialogue(dialogue, signName);
        Debug.Log("Interacting with sign post");
    }
}
