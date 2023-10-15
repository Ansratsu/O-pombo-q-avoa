using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_Death : MonoBehaviour
{
    bool paused;
	int countFrames;
	public GameObject PausePanel;
	public GameObject DeathPanel;
	public GameObject WinPanel;
	
	//PausePanel = GetComponent<PausePanel>();
	//DeathPanel = GetComponent<DeathPanel>();
	
	// Start is called before the first frame update
    void Start()
    {
        paused = false;
		PausePanel.SetActive(false);
		DeathPanel.SetActive(false);
		WinPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(paused)
			{
				paused = false;
				PausePanel.SetActive(false);
				ResumeGame();
			}
			else
			{
				PausePanel.SetActive(true);
				PauseGame();
				paused = true;
			}
		}
		
		if(ControlaJogadorMouseEsquerdo.acabou)
		{
			DeathPanel.SetActive(true);
			PauseGame();
			paused = true;
		}
		
		if(Boss.enemydeath)
		{
			PauseGame();
			paused = true;
			if(paused) countFrames++;
			if(countFrames >= 600) WinPanel.SetActive(true);
		}
    }
	
	void PauseGame()
	{
		Time.timeScale = 0;
	}
	
	void ResumeGame()
	{
		Time.timeScale = 1;
	}
}
