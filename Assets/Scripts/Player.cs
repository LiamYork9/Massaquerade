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

    public GameObject invenPan;

    public bool panIsOn;

   

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
         if (Input.GetKeyDown(KeyCode.I))
        {
            if(panIsOn == false )
            {
                TurnOnIn();
            }
            else
            {
                TurnOffIn();
            }
        }

        if(TextBoxManager.Instance.lockedTarget == true)
        {
            invenPan.SetActive(false);
        }
       
      
    }

    public void TurnOnIn()
    {
        invenPan.SetActive(true);
        panIsOn = true;
    }
    public void TurnOffIn()
    {
        invenPan.SetActive(false);
        panIsOn = false;
    }
}
