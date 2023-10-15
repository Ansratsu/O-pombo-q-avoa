using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add me!!
public class StageBegin : MonoBehaviour
{
	public void OnStageBeginButton()
	{
		SceneManager.LoadScene("Main_Game");
	}

}