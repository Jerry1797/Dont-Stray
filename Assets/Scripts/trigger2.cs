using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger2 : MonoBehaviour {

	public GameObject textUI_1;
	public GameObject textUI_2;
	public GameObject textUI_3;
	public GameObject textUI_4;
	public GameObject textUI_5;

	void OnTriggerEnter2D(Collider2D other)
	{
		textUI_1.gameObject.SetActive (false);
		textUI_2.gameObject.SetActive (true);
		textUI_3.gameObject.SetActive (false);
		textUI_4.gameObject.SetActive (false);
		textUI_5.gameObject.SetActive (false);
	}
}
