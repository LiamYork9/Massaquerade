using System.Collections.Generic;
using UnityEngine;

public class randomNPC : MonoBehaviour
{
    public GameObject Wolf;
    public GameObject Cat;
    public GameObject Peacock;
    public GameObject Hornet;
    public GameObject Bunny;
    public NPC WolfNpc;
    public NPC CatNpc;
    public NPC PeacockNpc;
    public NPC HornetNpc;
    public NPC BunnyNpc;

    public List<NPC> characters;

    // public bool wolfTrue = false;
    // public bool catTrue = false;
    // public bool peacockTrue = false;
    // public bool hornetTrue = false;
    // public bool bunnyTrue = false;

    public int numb;
    public int number;
    public int plsWork;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WolfNpc = Wolf.GetComponent<NPC>(); 
        CatNpc = Cat.GetComponent<NPC>();   
        PeacockNpc = Peacock.GetComponent<NPC>();
        HornetNpc = Hornet.GetComponent<NPC>();
        BunnyNpc = Bunny.GetComponent<NPC>();

        characters.Add(WolfNpc); 
        characters.Add(CatNpc);
        characters.Add(PeacockNpc);
        characters.Add(HornetNpc);
        characters.Add(BunnyNpc);
 
        // Wolf.SetActive(false);
        // Cat.SetActive(false);
        // Peacock.SetActive(false);
        // Hornet.SetActive(false);
        // Bunny.SetActive(false);

        for(int i = 0; i<characters.Count; i++)
            {
                characters[i].activeScene = Random.Range(1,4);
            }

        SpreadGuests();      

        SetSceneActive(1);
    }

    public void SetSceneActive(int sceneNum)
    {
        for(int i = 0; i<characters.Count; i++)
        {
            if(characters[i].activeScene == sceneNum)
            {
                characters[i].gameObject.SetActive(true);
            }
            else
            {
                characters[i].gameObject.SetActive(false);
            }
            
        }
    }

    public void SpreadGuests()
    {
        List<int> roomCount = new List<int>(){0,0,0};

        for(int i = 0; i<3; i++)
        {
            for(int j = 0; i<characters.Count; i++)
            {
                if(characters[j].activeScene == i+1)
                {
                    if(roomCount[i]<2)
                    {
                        roomCount[i]++;
                    }
                    else
                    {
                        characters[j].activeScene = ((characters[j].activeScene + 1)%3)+1;
                    }
                }
            }
        }

        for (int i = 0; i<roomCount.Count; i++)
        {
            if (roomCount[i] > 2)
            {
                for(int j = 0; j<characters.Count; i++)
                {
                    characters[j].activeScene = Random.Range(1,4);
                }
                SpreadGuests();
            }
        }
    }

    

    
}
