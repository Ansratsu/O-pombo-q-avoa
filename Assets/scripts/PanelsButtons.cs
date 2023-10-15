using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add me!!
public class PanelsButtons : MonoBehaviour
{
	public void OnBackTitleButton()
	{
		SceneManager.LoadScene("Title");
	}
	
	public void OnBackStageButton()
	{
		SceneManager.LoadScene("Stage_Begin");
	}

	public void OnNextButton()
	{
		SceneManager.LoadScene("Stage_Finish");
	}

}