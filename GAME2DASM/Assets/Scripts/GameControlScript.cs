using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{

    public Text tienText;
    public static int moneyAmount;
    int isGunSold;
    public GameObject non;
    // Use this for initialization
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        isGunSold = PlayerPrefs.GetInt("IsGunSold");
        if (isGunSold == 1)
            non.SetActive(true);
        else
            non.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        tienText.text = "Tien: " + moneyAmount.ToString() + " Beri";
    }
    public void gotoShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("ShopScene");
    }
}
