using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCounter : GameManager {

    public GameObject board;
    public GameObject lifeobjt;
    public GameObject scoreobjt;

    public string scoretext;
    public int score;
    public int life;
    public Sprite life5;
    public Sprite life4;
    public Sprite life3;
    public Sprite life2;
    public Sprite life1;


	// Use this for initialization
	public void Start () {
        life5 = Resources.Load<Sprite>("peroka5") as Sprite;
        life4 = Resources.Load<Sprite>("peroka4") as Sprite;
        life3 = Resources.Load<Sprite>("peroka3") as Sprite;
        life2 = Resources.Load<Sprite>("peroka2") as Sprite;
        life1 = Resources.Load<Sprite>("peroka1") as Sprite;      
    }

    public void ScoreCounting( int _score)
    {
        _score = score;
        scoretext = ( "" + score);
        this.gameObject.GetComponent<UnityEngine.UI.Text>().text = scoretext;
    }

    public void LifeCouting (int _life)
    {
        _life = life;
        if (life == 5)
        {
            this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = life5;
        }
        if (life == 4)
        {
            this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = life4;
        }
        if (life == 3)
        {
            this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = life3;
        }
        if (life == 2)
        {
            this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = life2;
        }
        if (life == 1)
        {
            this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = life1;
        }
        Debug.Log("lifes");
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
