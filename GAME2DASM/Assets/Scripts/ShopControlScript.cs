using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlScript : MonoBehaviour {

	int moneyAmount;
	int isRifleSold;
	public Text tienText;
	public Text giaText;
	public Button buy;
	public GameObject non;
	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
		
	}
	void Update () {	
		tienText.text = "Tien: " + moneyAmount.ToString() + " Beri";
		isRifleSold = PlayerPrefs.GetInt ("IsGunSold");

		if (isRifleSold ==1)
		{
			non.SetActive(true);
		}else
		{
			non.SetActive(false);
		}
		if (moneyAmount >= 5 && isRifleSold == 0)
			buy.interactable = true;
			
		else
			buy.interactable = false;
			
				
	}
	public void buyRifle()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt ("IsGunSold", 1);
		giaText.text = "BUYED!";
		buy.gameObject.SetActive (false);
		non.SetActive(true);
	}

	public void exitShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("Game1");
	}

	public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		buy.gameObject.SetActive (true);
		non.SetActive(false);
		giaText.text = "Gia: 5 Beri";
		PlayerPrefs.DeleteAll ();
	}

}
