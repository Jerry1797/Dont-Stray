using UnityEngine;
using System.Collections;

public class ResumeGame : MonoBehaviour {

	public void Resume(GameObject pause)
	{
		pause.gameObject.SetActive (false);
		Time.timeScale = 1;
	}
}
