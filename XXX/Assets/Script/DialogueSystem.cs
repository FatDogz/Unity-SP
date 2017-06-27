using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueSystem : MonoBehaviour {
    public static DialogueSystem Instant { get; set; }
    public GameObject dialoguePanel;

    public string npcName;
    public List<string> dialogueLines = new List<string>();

    Button contButton;
    Text dialogueText, nameText;
    int dialogueIndex;



	// Use this for initialization
	void Awake () {
        contButton = dialoguePanel.transform.Find("Continue").GetComponent<Button>();
        dialogueText = dialoguePanel.transform.Find("Text").GetComponent<Text>();
        nameText = dialoguePanel.transform.Find("Name").GetChild(0).GetComponent<Text>();
        contButton.onClick.AddListener(delegate { ContinuesDialogue(); });
        dialoguePanel.SetActive(false);




		if(Instant !=null && Instant !=this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instant = this;
        }
	}
	
	public void AddNewDialouge(string[] lines, string npcName)
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>();
        foreach (string line in lines)
        {
            dialogueLines.Add(line);
        }
        this.npcName = npcName;

        Debug.Log(dialogueLines.Count);
        CreateDialogue();
    }

    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = npcName;
        dialoguePanel.SetActive(true);
    }
    public void ContinuesDialogue()
    {
        if (dialogueIndex < dialogueLines.Count-1)
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
