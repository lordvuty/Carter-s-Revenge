using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Player MyPlayer;
    public Arrow[] MyArrow;
    public Girl MyGirl;
    public GameCounter gameCounter;
    private int arrownumber;
    public int lifes = 5;
    public int scorecounting = 0;


	// Use this for initialization
	void Start () {

        MyPlayer = ScriptableObject.CreateInstance<Player>();
        MyPlayer.init();
        MyGirl = ScriptableObject.CreateInstance<Girl>();
        MyGirl.init();

        arrownumber = 8;

        MyArrow = new Arrow[arrownumber];

        for (int i = 0; i < arrownumber; i++)
        {
            MyArrow[i] = ScriptableObject.CreateInstance<Arrow>();

            float randx = Random.Range(0, 20);

            Vector3 p = new Vector3(randx, 5.5f, 0);

            MyArrow[i].init(p);
        }
    }
	
	// Update is called once per frame
	void Update () {
        
        MyPlayer.Update();

        for (int i = 0; i < arrownumber; i++)
        {
            MyArrow[i].Update();
        }

        MyGirl.Update();

        //gameCounter.Start();

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player" && coll.gameObject.tag == "arrow")
        {
            lifes = lifes - 1;
            gameCounter.LifeCouting(lifes);
        }
        if (coll.gameObject.tag == "Player" && coll.gameObject.tag == "girl")
        {
            scorecounting = scorecounting + 1;
            gameCounter.ScoreCounting(scorecounting);
        }

        //gameCounter.ScoreCounting(score);
    }
}
