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

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        currentPanel = null;
        nextPanel = null;
    }
    public void Fade(){
        animator.SetTrigger("fade");
    }
    
    
    public void Panel1to2(){
        currentPanel = panel1;
        nextPanel = panel2;
        Fade();
    }
    public void Panel1to3(){
        currentPanel = panel1;
        nextPanel = panel3;
        Fade();
    }
    public void Panel2to3(){
        currentPanel = panel2;
        nextPanel = panel3;
        Fade();
        Debug.Log("pressed");
    }
    public void Panel2to1(){
        currentPanel = panel2;
        nextPanel = panel1;
        Fade();
    }
    public void Panel3to2(){
        currentPanel = panel3;
        nextPanel = panel2;
        Fade();
    }
    public void Panel3to1(){
        currentPanel = panel3;
        nextPanel = panel1;
        Fade();
    }
    public void Transition(){
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }
    
}
