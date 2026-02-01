using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

 public enum Quirk
{
    Tired,
    Drunk,
    BadDay,
    NotInvited,
    Sick,
    Suspicious

}

public class Quirks : DialogSegment {
    
  [Output(dynamicPortList = true)]
    public List<Quirk> quirk;
	
	public override object GetValue(NodePort port) {

		if(port.fieldName.Contains("Answers"))
        {
			for(int i =0; i< quirk.Count; i++)
            {
                if(port.fieldName == "Answers " + i)
                {
                    return quirk[i];
                }
            }
		}
		return Mask.Default; // Replace this
	}
}