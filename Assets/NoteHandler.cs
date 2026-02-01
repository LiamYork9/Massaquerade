using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class NoteHandler : MonoBehaviour
{
    public TMP_Text likes;
     public TMP_Text dislikes;
    public TMP_Text quirk;

    public TargetPicker targetPicker;

    public GameObject theNote;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        likes.text = "Likes: "+ targetPicker.theTarget.GetComponent<NPC>().Likes[0];
        dislikes.text = "Dislikes: "+ targetPicker.theTarget.GetComponent<NPC>().Dislikes[0];
        quirk.text = "Quirk: "+ targetPicker.theTarget.GetComponent<NPC>().Quirks[0];
    }

    // Update is called once per frame
    void Update()
    {
        //  likes.text = "Likes: "+ targetPicker.theTarget.GetComponent<NPC>().Likes[0];
        //  dislikes.text = "Dislikes: "+ targetPicker.theTarget.GetComponent<NPC>().Dislikes[0];
        //  quirk.text = "Quirk: "+ targetPicker.theTarget.GetComponent<NPC>().Quirks[0];
    }

    public void TurnThisOff()
    {
        theNote.SetActive(false);
    }
     public void TurnThisOn()
    {
        theNote.SetActive(true);
    }
    

}
