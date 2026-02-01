using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
public class TargetPicker : MonoBehaviour
{
     public List<GameObject> choices;

     public GameObject killTarget;

     public GameObject winScreen;

      public GameObject loseScreen;

     public Image deathImage;

     public List<String> Quirks;

    public List<String> DislikesLikes;

    public GameObject theTarget;

    
    void OnEnable()
    {
        

         if (choices != null && choices.Count > 0)
        {
           GameObject randomTarget = GetRandomObject(choices);
           randomTarget.GetComponent<NPC>().Target = true;
           theTarget = randomTarget;
           choices.Remove(randomTarget);

            GameObject randomDetective = GetRandomObject(choices);
            randomDetective.GetComponent<NPC>().Detective = true;
             choices.Remove(randomDetective);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public GameObject GetRandomObject(List<GameObject> list)
    {
        
        int randomIndex = UnityEngine.Random.Range(0, list.Count);

       
        return list[randomIndex];
    }

    public void KillTarget()
    {
       if(killTarget.GetComponent<NPC>().Target == true)
        {
            Debug.Log("You win");
            winScreen.SetActive(true);
            deathImage.sprite  = killTarget.GetComponent<NPC>().deathSprite ;

        }
        else
        {
            Debug.Log("Wrong Guy");
            loseScreen.SetActive(true);
            
        }
    }
}
