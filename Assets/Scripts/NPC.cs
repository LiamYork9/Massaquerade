using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NPC : MonoBehaviour, IDropHandler
{
    public bool Target = false;

    public bool Detective = false;

    public int activeScene = 0;

    public int Positive = 0;

    public int Negative = 0;

    public Dialogue text;

    public DialogGraph likesYou;

    public DialogGraph hatesYou;

    public Sprite deathSprite;

    public List<String> Quirks = new List<string>();

    public List<String> Likes;

    public List<String> Dislikes;

    public TargetPicker targetPicker;

     public DialogueInteraction dialogueInteraction;

     public Dialogue dialogue;

     public GameObject contents = null;

     public DialogGraph giftGraph;
    
    void OnEnable()
    {
         if ( Quirks.Count <= 0)
        {
           String randomQuirk = GetRandomObject(targetPicker.Quirks);
           Quirks.Add(randomQuirk);
          
          
        }
         if ( Likes.Count <= 0)
        {
           String randomLikes = GetRandomObject(targetPicker.DislikesLikes);
           Likes.Add(randomLikes);
           
          
        }
         if ( Dislikes.Count <= 0)
        {
           String randomDislikes = GetRandomObject(targetPicker.DislikesLikes);
           Dislikes.Add(randomDislikes);
          
          
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Negative == 15)
        {
            text.lines = hatesYou;
        }
         if(Positive == 15)
        {
            text.lines = likesYou;
        }
    }

    public String GetRandomObject(List<String> list)
    {
        
        int randomIndex = UnityEngine.Random.Range(0, list.Count);

       
        return list[randomIndex];
    }

    public void OnDrop(PointerEventData eventData)
    {
            dialogue.lines = giftGraph;
            (dialogue.activeSegment as LikesAndDislikesNode).GetInputValue("Ask", contents.GetComponent<ItemHolder>().itemName );
            Debug.Log(contents.GetComponent<ItemHolder>().itemName);
          
        
            dialogueInteraction.StartDialogue();
        
    }
}
