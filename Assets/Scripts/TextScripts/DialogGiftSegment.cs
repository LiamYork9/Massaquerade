using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class DialogGiftSegment : DialogSegment {

    public List<string> Options;

    [Output] public String Answer;
	
	public override object GetValue(NodePort port) {

		return Answer;
	}
}
