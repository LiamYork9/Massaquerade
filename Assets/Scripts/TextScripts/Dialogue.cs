using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;


public class Dialogue : MonoBehaviour
{
  
    public DialogGraph orginalGraph;

    public DialogGraph lines;


    public DialogSegment activeSegment;
    public float textSpeed;

    private int index;


    //public PlayerController pc;

    public bool textActive = false;
    public UnityEvent EndDialogueEvent;

     public string[] dialogText;

    public NPC npc;
    void Start()
    {
        if (EndDialogueEvent == null)
        {
            EndDialogueEvent = new UnityEvent();
        }
          
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && textActive == true)
        {
            LineSkip();
        }

    }

    public void LineSkip()
    {
        
        if ( TextBoxManager.Instance.textComponent.text == activeSegment.DialogText[index])
        {
             if (index < activeSegment.DialogText.Length - 1)
             {
                NextLine();
             }
            else
            {
                NextNode();
            }
        }
        else
        {
            StopAllCoroutines();
             TextBoxManager.Instance.textComponent.text = activeSegment.DialogText[index];
        }
    }
    
     

    public void StartDiolague()
    {
        Debug.Log("Start Text");
         foreach (DialogSegment node in lines.nodes)
            {
                if (!node.GetInputPort("input").IsConnected)
                {
                    UpdateDialog(node);
                }
            }
         TextBoxManager.Instance.nameText.text = activeSegment.speakerName;
         TextBoxManager.Instance.portrait.sprite = activeSegment.portrait;
        textActive = true;
        //pc = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        TextBoxManager.Instance.textBox.Play("TextboxUp");
         
         TextBoxManager.Instance.textComponent.text = string.Empty;
        index = 0;
        //pc.inText = true;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in activeSegment.DialogText[index].ToCharArray())
        {
             TextBoxManager.Instance.textComponent.text += c;
            yield return new WaitForSecondsRealtime(textSpeed);
        }

    }

    public void NextLine()
    {
       
        
            index++;
             TextBoxManager.Instance.textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        
      
    }

    public void NextNode()
    {
        if(activeSegment is DialogAnswerSegments){
        
            if((activeSegment as DialogAnswerSegments).Answers.Count > 0)
            {
                 int answerIndex = 0;
                  foreach (Transform child in  TextBoxManager.Instance.buttonParent)
                    {
                        Destroy(child.gameObject);
                    }
                 
                 foreach(string answer in (activeSegment as DialogAnswerSegments).Answers)
                {
                   
                    GameObject btn = Instantiate( TextBoxManager.Instance.buttonPrefab,  TextBoxManager.Instance.buttonParent);
                    btn.GetComponentInChildren<TMP_Text>().text = answer;

                    int index = answerIndex;

                     btn.GetComponentInChildren<Button>().onClick.AddListener((() => { AnswerClicked(index); }));

                    answerIndex++;
                }
            }
           
            else
            {
                if (activeSegment.GetPort("output").IsConnected)
                {
                    UpdateDialog(activeSegment.GetPort("output").Connection.node as DialogSegment);
                     TextBoxManager.Instance.textComponent.text = string.Empty;
                    StartCoroutine(TypeLine());
                }
                else
                {
                    EndDialogue();
                }
            }
           
        }
        else if(activeSegment is DialogGiftSegment){
        
            if((activeSegment as DialogGiftSegment).Options.Count > 0)
            {
                 int answerIndex = 0;
                  foreach (Transform child in  TextBoxManager.Instance.buttonParent)
                    {
                        Destroy(child.gameObject);
                    }
                 
                 foreach(string answer in (activeSegment as DialogGiftSegment).Options)
                {
                   
                    GameObject btn = Instantiate( TextBoxManager.Instance.buttonPrefab,  TextBoxManager.Instance.buttonParent);
                    btn.GetComponentInChildren<TMP_Text>().text = answer;

                    int index = answerIndex;

                     btn.GetComponentInChildren<Button>().onClick.AddListener((() => { GiftClicked(index); }));

                    answerIndex++;
                }
            }
           
            else
            {
                if (activeSegment.GetPort("output").IsConnected)
                {
                    UpdateDialog(activeSegment.GetPort("output").Connection.node as DialogSegment);
                     TextBoxManager.Instance.textComponent.text = string.Empty;
                    StartCoroutine(TypeLine());
                }
                else
                {
                    EndDialogue();
                }
            }
           
        }
         else if((activeSegment is DialogPointSegment))
            {
                npc.Positive += (activeSegment as DialogPointSegment).PositivePoints;
                npc.Negative += (activeSegment as DialogPointSegment).NegativePoints;
                if (activeSegment.GetPort("output").IsConnected)
                {
                    UpdateDialog(activeSegment.GetPort("output").Connection.node as DialogSegment);
                     TextBoxManager.Instance.textComponent.text = string.Empty;
                    StartCoroutine(TypeLine());
                }
                else
                {
                    EndDialogue();
                }
            }
        else if((activeSegment is DialogueUpadateNode))
        {
            int temp = npc.Positive - npc.Negative;
            for(int i = 0; i < (activeSegment as DialogueUpadateNode).lowpoints.Count;i++)
            {
                if((activeSegment as DialogueUpadateNode).lowpoints[i] <= temp && temp <= (activeSegment as DialogueUpadateNode).highpoints[i])
                {
                    XNode.NodePort port = activeSegment.GetPort("highpoints " + i);
                    if (port.IsConnected)
                    {
                        UpdateDialog(port.Connection.node as DialogSegment);
                        LineSkip();
                    }

                    else
                    {
                        EndDialogue();
                    }
                    break;
                }
               
            }
        }
        else if(activeSegment is LikesAndDislikesNode)
        {
            Debug.Log((activeSegment as LikesAndDislikesNode).GetValue((activeSegment as LikesAndDislikesNode).GetPort("Ask")));
            if(npc.Likes.Contains((activeSegment as LikesAndDislikesNode).GetInputValue("Ask", (activeSegment as LikesAndDislikesNode).Ask)))
            {
                UpdateDialog(activeSegment.GetPort("Opinion 0").Connection.node as DialogSegment);
                TextBoxManager.Instance.textComponent.text = string.Empty;
                StartCoroutine(TypeLine());
            }
            else if(npc.Dislikes.Contains((activeSegment as LikesAndDislikesNode).GetInputValue("Ask",  (activeSegment as LikesAndDislikesNode).Ask)))
            {
                UpdateDialog(activeSegment.GetPort("Opinion 2").Connection.node as DialogSegment);
                TextBoxManager.Instance.textComponent.text = string.Empty;
                StartCoroutine(TypeLine());
            }
            else
            {
                UpdateDialog(activeSegment.GetPort("Opinion 1").Connection.node as DialogSegment);
                TextBoxManager.Instance.textComponent.text = string.Empty;
                StartCoroutine(TypeLine());
            }
        }
        else if(activeSegment is DialogMaskSegment)
        {
            for(int i = 0; i<(activeSegment as DialogMaskSegment).Masks.Count; i++)
            {
                if(Player.Instance.mask == (activeSegment as DialogMaskSegment).Masks[i])
                {
                    UpdateDialog(activeSegment.GetPort("Masks " + i).Connection.node as DialogSegment);
                    TextBoxManager.Instance.textComponent.text = string.Empty;
                    StartCoroutine(TypeLine());
                    break;
                }
            }
        }
        else if(activeSegment is Quirks)
        {
            for(int i = 0; i<(activeSegment as Quirks).quirk.Count; i++)
            {
                if(npc.quirk == (activeSegment as Quirks).quirk[i])
                {
                    UpdateDialog(activeSegment.GetPort("quirk " + i).Connection.node as DialogSegment);
                    TextBoxManager.Instance.textComponent.text = string.Empty;
                    StartCoroutine(TypeLine());
                    break;
                }
            }
        }
        else
        {
             if (activeSegment.GetPort("output").IsConnected)
            {
                UpdateDialog(activeSegment.GetPort("output").Connection.node as DialogSegment);
                  TextBoxManager.Instance.textComponent.text = string.Empty;
                 StartCoroutine(TypeLine());
            }
            else
            {
                EndDialogue();
            }
           
        }
           
        
    }

     public void AnswerClicked(int clickedIndex)
    {
        XNode.NodePort port = activeSegment.GetPort("Answers " + clickedIndex);
        if (port.IsConnected)
        {
            UpdateDialog(port.Connection.node as DialogSegment);
            LineSkip();
        }

        else
        {
            EndDialogue();
        }
            
    }

    public void GiftClicked(int clickedIndex)
    {
        (activeSegment as DialogGiftSegment).Answer = (activeSegment as DialogGiftSegment).Options[clickedIndex];
        XNode.NodePort port = activeSegment.GetPort("Answer");
        if (port.IsConnected)
        {
            UpdateDialog(port.Connection.node as DialogSegment);
            LineSkip();
        }
        else
        {
            EndDialogue();
        }
            
    }

    public void EndDialogue()
    {
        Debug.Log("End here");
       
         foreach (Transform child in  TextBoxManager.Instance.buttonParent)
        {
            Destroy(child.gameObject);
        }
        textActive = false;
        //pc.inText = false;
        TextBoxManager.Instance.textBox.Play("TextboxDown");
       
        //gameObject.SetActive(false);
        TextBoxManager.Instance.skip.SetActive(false);
        TextBoxManager.Instance.nameTextObj.SetActive(false);
        TextBoxManager.Instance.Objportrait.SetActive(false);
        TextBoxManager.Instance.killButton.SetActive(false);
        Time.timeScale = 1.0f;
         TextBoxManager.Instance.textComponent.text = string.Empty;
         lines = orginalGraph;
        //topBox.SetActive(false);
        EndDialogueEvent.Invoke();
        TextBoxManager.Instance.NoTalk = false;
        TextBoxManager.Instance.lockedTarget = false;
       
        
    }

     public void UpdateDialog(DialogSegment newSegment)
        {
            index = 0;
            activeSegment = newSegment;
            dialogText = newSegment.DialogText;
            TextBoxManager.Instance.nameText.text = activeSegment.speakerName;
            TextBoxManager.Instance.portrait.sprite = activeSegment.portrait;
            foreach (Transform child in  TextBoxManager.Instance.buttonParent)
            {
                Destroy(child.gameObject);
            }
          
        }

}
