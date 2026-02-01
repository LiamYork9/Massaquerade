using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;


public class DialogMaskSegment : DialogSegment {

  [Output(dynamicPortList = true)]
    public List<Mask> Masks;
	
	public override object GetValue(NodePort port) {

		if(port.fieldName.Contains("Answers"))
        {
			for(int i =0; i< Masks.Count; i++)
            {
                if(port.fieldName == "Answers " + i)
                {
                    return Masks[i];
                }
            }
		}
		return Mask.Default; // Replace this
	}
}
