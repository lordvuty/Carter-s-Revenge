using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : ElementoGrafico {

    public Vector3 vel;

    public void init(Vector3 _pos) {
        
        pos = _pos;

        gobj = Instantiate(Resources.Load("arrowprefab", typeof(GameObject))) as GameObject;

        gobj.transform.localScale = new Vector3(1, 1, 1);
        gobj.transform.position = pos;

        vel = new Vector3(-0.05f, -0.05f, 0);
        pos += vel.normalized;

    }
    public void mover() {

        //pos += vel.normalized;
        gobj.transform.Translate(vel * Time.deltaTime * 50, Space.World);

        if (gobj.transform.position.y <= -2)
        {
            float randx = Random.Range(0, 20);
            gobj.transform.position = new Vector3 (randx, 5.5f, 0);
        }
    }

    // Update is called once per frame
    public void Update () {
        
        mover();

    }
}
