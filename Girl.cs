using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : ElementoGrafico {

    public Animator anim;

    Vector3 pos;

    public void init()
    {



        pos = new Vector3(9.5f, -2.8f, 0);

        gobj = Instantiate(Resources.Load("girl", typeof(GameObject))) as GameObject;

        gobj.transform.localScale = new Vector3(3, 2.5f, 1);
        gobj.transform.position = pos;

        anim = gobj.GetComponent<Animator>();

    }

    public void mover() {

    }

    // Update is called once per frame
    public void Update () {
        mover();
	}
}
