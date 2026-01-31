using UnityEngine;

public class KillTarget : MonoBehaviour
{
    public TargetPicker targetPicker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewTarget()
    {
        targetPicker.killTarget = this.gameObject;
    }
}
