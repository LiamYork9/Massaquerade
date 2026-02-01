using UnityEngine;

public class randomNPC : MonoBehaviour
{
    public GameObject Wolf;
    public GameObject Cat;
    public GameObject Peacock;
    public GameObject Hornet;
    public GameObject Bunny;
    public GameObject Wolf2;
    public GameObject Cat2;
    public GameObject Peacock2;
    public GameObject Hornet2;
    public GameObject Bunny2;
    public GameObject Wolf3;
    public GameObject Cat3;
    public GameObject Peacock3;
    public GameObject Hornet3;
    public GameObject Bunny3;
    public bool wolfTrue = false;
    public bool catTrue = false;
    public bool peacockTrue = false;
    public bool hornetTrue = false;
    public bool bunnyTrue = false;

    public int numb;
    public int number;
    public int plsWork;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            Wolf.SetActive(false);
            Cat.SetActive(false);
            Peacock.SetActive(false);
            Hornet.SetActive(false);
            Bunny.SetActive(false);
            Wolf2.SetActive(false);
            Cat2.SetActive(false);
            Peacock2.SetActive(false);
            Hornet2.SetActive(false);
            Bunny2.SetActive(false);
            Wolf3.SetActive(false);
            Cat3.SetActive(false);
            Peacock3.SetActive(false);
            Hornet3.SetActive(false);
            Bunny3.SetActive(false);
        number = Random.Range(1, 10);
        if (number == 1)
        {
            Wolf.SetActive(true);
            wolfTrue = true;
            Cat.SetActive(true);
            catTrue = true;
            plsWork = 1;
            Debug.Log("1");
        }
        if (number == 2)
        {
            Wolf.SetActive(true);
            wolfTrue = true;
            Peacock.SetActive(true);
            peacockTrue = true;
            plsWork = 2;
            Debug.Log("2");
        }
        if (number == 3)
        {
            Wolf.SetActive(true);
            wolfTrue = true;
            Hornet.SetActive(true);
            hornetTrue = true;
            plsWork = 3;
            Debug.Log("3");
        }
        if (number == 4)
        {
            Wolf.SetActive(true);
            wolfTrue = true;
            Bunny.SetActive(true);
            bunnyTrue = true;
            plsWork = 4;
            Debug.Log("1");
        }
        if (number == 5)
        {
            Cat.SetActive(true);
            catTrue = true;
            Peacock.SetActive(true);
            peacockTrue = true;
            plsWork = 5;
            Debug.Log("1");
        }
        if (number == 6)
        {
            Cat.SetActive(true);
            catTrue = true;
            Hornet.SetActive(true);
            hornetTrue = true;
            plsWork = 6;
            Debug.Log("2");
        }
        if (number == 7)
        {
            Cat.SetActive(true);
            catTrue = true;
            Bunny.SetActive(true);
            bunnyTrue = true;
            plsWork = 7;
            Debug.Log("3");
        }
        if (number == 8)
        {
            Peacock.SetActive(true);
            peacockTrue = true;
            Hornet.SetActive(true);
            hornetTrue = true;
            plsWork = 8;
            Debug.Log("1");
        }
        if (number == 9)
        {
            Peacock.SetActive(true);
            peacockTrue = true;
            Bunny.SetActive(true);
            bunnyTrue = true;
            plsWork = 9;
            Debug.Log("2");
        }
        if (number == 10)
        {
            Hornet.SetActive(true);
            hornetTrue = true;
            Bunny.SetActive(true);
            bunnyTrue = true;
            plsWork = 10;
            Debug.Log("1");
        }

        numb = Random.Range(1, 3);
        if (plsWork == 1)
        {
            if (numb == 1)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Hornet2.SetActive(true);
                hornetTrue = true;
                
                Debug.Log("1");
            }
            if (numb == 2)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;
                
                Debug.Log("2");
            }
            if (numb == 3)
            {
                Hornet2.SetActive(true);
                hornetTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;
                
                Debug.Log("1");
            }    
        }
        if (plsWork == 2)
        {
            if (numb == 1)
            {
                Cat2.SetActive(true);
                catTrue = true;
                Hornet2.SetActive(true);
                hornetTrue = true;
                
                Debug.Log("1");
            }
            if (numb == 2)
            {
                Cat2.SetActive(true);
                catTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;
                
                Debug.Log("2");
            }
            if (numb == 3)
            {
                Hornet2.SetActive(true);
                hornetTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;
                
                Debug.Log("1");
            } 
        }
        if (plsWork == 3)
        {
            if (numb == 1)
            {
                Cat2.SetActive(true);
                catTrue = true;
                Peacock2.SetActive(true);
                peacockTrue = true;
                
                Debug.Log("1");
            }
            if (numb == 2)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;
                
                Debug.Log("2");
            }
            if (numb == 3)
            {
                Cat2.SetActive(true);
                catTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;
                
                Debug.Log("1");
            } 
        }
        if (plsWork == 4)
        {
            if (numb == 1)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Hornet2.SetActive(true);
                hornetTrue = true;
                
                Debug.Log("1");
            }
            if (numb == 2)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Cat2.SetActive(true);
                catTrue = true;
                
                Debug.Log("2");
            }
            if (numb == 3)
            {
                Hornet2.SetActive(true);
                hornetTrue = true;
                Cat2.SetActive(true);
                catTrue = true;
                
                Debug.Log("1");
            } 
        }
        if (plsWork == 5)
        {
            if (numb == 1)
            {
                Wolf2.SetActive(true);
                wolfTrue = true;
                Hornet2.SetActive(true);
                hornetTrue = true;

                Debug.Log("1");
            }
            if (numb == 2)
            {
                Wolf2.SetActive(true);
                wolfTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;

                Debug.Log("2");
            }
            if (numb == 3)
            {
                Hornet2.SetActive(true);
                hornetTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;

                Debug.Log("1");
            }
        }
        if (plsWork == 6)
        {
            if (numb == 1)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Wolf2.SetActive(true);
                wolfTrue = true;
                
                Debug.Log("1");
            }
            if (numb == 2)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;
                
                Debug.Log("2");
            }
            if (numb == 3)
            {
                Wolf2.SetActive(true);
                wolfTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;
                
                Debug.Log("1");
            } 
        }
        if (plsWork == 7)
        {
            if (numb == 1)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Hornet2.SetActive(true);
                hornetTrue = true;
                
                Debug.Log("1");
            }
            if (numb == 2)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Wolf2.SetActive(true);
                wolfTrue = true;
                
                Debug.Log("2");
            }
            if (numb == 3)
            {
                Hornet2.SetActive(true);
                hornetTrue = true;
                Wolf2.SetActive(true);
                wolfTrue = true;
                
                Debug.Log("1");
            } 
        }
        if (plsWork == 8)
        {
            if (numb == 1)
            {
                Wolf2.SetActive(true);
                wolfTrue = true;
                Cat2.SetActive(true);
                catTrue = true;
                
                Debug.Log("1");
            }
            if (numb == 2)
            {
                Wolf2.SetActive(true);
                wolfTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;
                
                Debug.Log("2");
            }
            if (numb == 3)
            {
                Cat2.SetActive(true);
                catTrue = true;
                Bunny2.SetActive(true);
                bunnyTrue = true;
                
                Debug.Log("1");
            } 
        }
        if (plsWork == 9)
        {
            if (numb == 1)
            {
                Wolf2.SetActive(true);
                wolfTrue = true;
                Hornet2.SetActive(true);
                hornetTrue = true;
                
                Debug.Log("1");
            }
            if (numb == 2)
            {
                Wolf2.SetActive(true);
                wolfTrue = true;
                Cat2.SetActive(true);
                catTrue = true;
                
                Debug.Log("2");
            }
            if (numb == 3)
            {
                Hornet2.SetActive(true);
                hornetTrue = true;
                Cat2.SetActive(true);
                catTrue = true;
                
                Debug.Log("1");
            } 
        }
        if (plsWork == 10)
        {
            if (numb == 1)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Wolf2.SetActive(true);
                wolfTrue = true;
                
                Debug.Log("1");
            }
            if (numb == 2)
            {
                Peacock2.SetActive(true);
                peacockTrue = true;
                Cat2.SetActive(true);
                catTrue = true;
                
                Debug.Log("2");
            }
            if (numb == 3)
            {
                Wolf2.SetActive(true);
                wolfTrue = true;
                Cat2.SetActive(true);
                catTrue = true;
                
                Debug.Log("1");
            } 
        }


        if (wolfTrue != true)
        {
            Wolf3.SetActive(true);
        }
        if (catTrue != true)
        {
            Cat3.SetActive(true);
        }
        if (peacockTrue != true)
        {
            Peacock3.SetActive(true);
        }
        if (hornetTrue != true)
        {
            Hornet3.SetActive(true);
        }
        if (bunnyTrue != true)
        {
            Bunny3.SetActive(true);
        }
    }

    
}
