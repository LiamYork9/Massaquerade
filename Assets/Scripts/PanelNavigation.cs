using UnityEngine;

public class PanelNavigation : MonoBehaviour
{

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Panel1to2(){
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    public void Panel1to3(){
        panel1.SetActive(false);
        panel3.SetActive(true);
    }
    public void Pane2to3(){
        panel2.SetActive(false);
        panel3.SetActive(true);
    }
    public void Panel2to1(){
        panel2.SetActive(false);
        panel1.SetActive(true);
    }
    public void Panel3to2(){
        panel3.SetActive(false);
        panel2.SetActive(true);
    }
    public void Panel3to1(){
        panel3.SetActive(false);
        panel1.SetActive(true);
    }
    
}
