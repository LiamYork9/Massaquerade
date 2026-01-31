using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class DialogueUpadateNode : DialogSegment {
    public List <int> lowpoints;

  [Output(dynamicPortList = true)]
     public List<int> highpoints;

    
	
	public override object GetValue(NodePort port) {
		return null; // Replace this
	}
}
