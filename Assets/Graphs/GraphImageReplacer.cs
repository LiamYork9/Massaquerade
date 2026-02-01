using UnityEngine;

public class GraphImageReplacer : MonoBehaviour
{
    public DialogGraph graph;
    public Sprite replacementPortrait;

    public string replacementName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReplaceBoth()
    {
        ReplaceImage();
        ReplaceName();
    }

    public void ReplaceImage()
    {
        foreach(DialogSegment node in graph.nodes)
        {
            node.portrait = replacementPortrait;
        }
        
    }

    public void ReplaceName()
    {
        foreach(DialogSegment node in graph.nodes)
        {
            node.speakerName = replacementName;
        }
    }
}
