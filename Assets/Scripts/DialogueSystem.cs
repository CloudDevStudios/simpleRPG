using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject dialoguePanel;
    [SerializeField]
    private Text dialogueText;
    [SerializeField]
    private Text npcNameText;
    [SerializeField]
    private Button continueButton;

    private int dialogueIndex;

    public static DialogueSystem Instance { get; set; }
    public List<string> dialogueLines = new List<string>();
    private string npcName;

    void Awake()
    {
        if(Instance != null && Instance != this) { Destroy(gameObject); }
        else { Instance = this; }

        continueButton.onClick.AddListener(delegate { ContinueDialog(); });
        dialoguePanel.SetActive(false);
    }

    public void AddNewDialogue(string[] lines, string npcName)
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>(lines.Length);
        dialogueLines.AddRange(lines);
        this.npcName = npcName;

        CreateDialog();
    }

    public void CreateDialog()
    {
        npcNameText.text = npcName;
        dialogueText.text = dialogueLines[dialogueIndex];
        dialoguePanel.SetActive(true);
    }

    public void ContinueDialog()
    {
        if(dialogueIndex < dialogueLines.Count - 1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            dialoguePanel.SetActive(false);
        }
    }
}
