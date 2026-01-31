using UnityEngine;

public class NPC : MonoBehaviour
{
    public bool Target = false;

    public bool Detective = false;

    public int Positive = 0;

    public int Negative = 0;

    public Dialogue text;

    public DialogGraph likesYou;

    public DialogGraph hatesYou;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
}
