using UnityEngine;

public enum Mask
{
    Default,
    Bunny,
    Wolf,
    Hornet,
    Cat,
    Peacock
}

public class Player : MonoBehaviour
{
    public static Player Instance;
    public Mask mask;

    void Awake()
    {
        if (Instance == null||Instance == this)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
