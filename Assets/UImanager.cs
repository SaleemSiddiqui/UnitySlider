using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour {

	public GameObject Slider;
	public Image img;

	public void onClick(Image obj){

		//Slider.SetActive ();
		img.gameObject.SetActive(true);
		img.enabled = true;
		img.sprite = obj.sprite;

	}

	public void onClickClose(){
		img.gameObject.SetActive(false);
	}

		
}
