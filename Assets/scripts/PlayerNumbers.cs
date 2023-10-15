using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNumbers : MonoBehaviour
{
    public static int playerHP;
	private int MAXHP = 3;
	public static int playerScore;
	public Text textoHP;
	public Text textoScore;
	
	void SetHPText(int playerHP)
	{
		textoHP.text = "HP " + playerHP.ToString() + "/" + MAXHP.ToString();
	}

	void SetScoreText(int playerScore)
	{
		textoScore.text = "Score: " + playerScore.ToString();
	}
	
	// Start is called before the first frame update
    void Start()
    {
        playerHP = MAXHP;
		playerScore = 0;
		SetHPText(playerHP);
		SetScoreText(playerScore);
    }

    // Update is called once per frame
    void Update()
    {
        SetHPText(playerHP);
		SetScoreText(playerScore);
    }
}
