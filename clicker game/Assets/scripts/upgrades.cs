using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgrades : MonoBehaviour {

    public GameObject scriptObject;
    public GameObject autoClickUpg1;

    public int autoClickUpg1Done = 0;
    private int clicked;
    private click otherScript;

	void Start () {
        otherScript = scriptObject.GetComponent<click>();
        clicked = otherScript.countNumber;
	}

    void Update()
    {
        if(autoClickUpg1Done == 1)
        {
            StartCoroutine(Autoclick());
        }
    }

    public void Autoclick1 () {
            autoClickUpg1Done += 1;
	}

    IEnumerator Autoclick()
    {
        yield return new WaitForSeconds(1);
        clicked += 1;
    }
}
