using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour {

	public int countNumber = 0;
	public GameObject countText;
	public GameObject firstText;
	public GameObject counter;

	public void clickFunc() {
		countNumber += 1;
	}

	void Update () {
		if (countNumber >= 1) {
            countText.GetComponent<Text>().text = countNumber.ToString();
            firstText.SetActive(false);
            counter.SetActive(true);
        }
	}
}