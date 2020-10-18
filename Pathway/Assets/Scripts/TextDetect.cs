using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDetect : MonoBehaviour
{
	public string location;
	public GameObject inputField;
	public GameObject text;

	public void StoreName(){
		location = inputField.GetComponent<Text>().text;
		text.GetComponent<Text>().text = "Finding art from " + location;
	}

}
 