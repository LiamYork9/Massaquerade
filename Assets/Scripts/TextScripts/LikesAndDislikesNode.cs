using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class LikesAndDislikesNode : DialogSegment 
{
	[Input] public string Ask;
	

  [Output(dynamicPortList = true)]
    public List<string> Opinion;

	public override object GetValue(NodePort port) {

		string Ask = GetInputValue<string>("Ask", this.Ask);
	   	if(port.fieldName=="Ask")
	   	{
			return Ask;
		}
	   else if (port.fieldName.Contains("Opinion"))
        {
            for(int i =0; i< Opinion.Count; i++)
            {
                if(port.fieldName == "Opinion " + i)
                {
                    return Opinion[i];
                }
            }
        }
        return null;
   }
	
}
