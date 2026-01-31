using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class LikesAndDislikesNode : DialogSegment {

  [Output(dynamicPortList = true)]
    public List<string> Likes;
	
	public override object GetValue(NodePort port) {
		return null; // Replace this
	}
}
