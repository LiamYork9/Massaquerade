using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


using System.Collections;

public class PanelNavigation : MonoBehaviour
{

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject currentPanel;
    public GameObject nextPanel;
    public randomNPC NPCs;

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        currentPanel = panel1;
        nextPanel = panel1;
        panel3.SetActive(false);
        panel2.SetActive(false);
    }
    public void Fade(){
        animator.SetTrigger("fade");
    }

    public void Panel1(){
        currentPanel = nextPanel;
        nextPanel = panel1;
        Fade();
        NPCs.SetSceneActive(1);
    }
    public void Panel2(){
        currentPanel = nextPanel;
        nextPanel = panel2;
        Fade();
        NPCs.SetSceneActive(2);
    }
    public void Panel3(){
        currentPanel = nextPanel;
        nextPanel = panel3;
        Fade();
        NPCs.SetSceneActive(3);
        Debug.Log("pressed");
    }
    public void Transition(){
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }
    
}
