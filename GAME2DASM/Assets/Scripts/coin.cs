using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coin : MonoBehaviour
{
    // public Text tienText;
    // public int moneyAmount;
    // Start is called before the first frame update
    void Start()
    {
        // moneyAmount = 0;
        // tienText.text = "Tien: " + moneyAmount + " Beri";
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("coin"))
        {
            AudioManager.instance.PlaySound(AudioManager.instance.coin, 1f);

            GameControlScript.moneyAmount += 2;
            Destroy(col.gameObject);
            // moneyAmount += 2;
            // tienText.text = "Tien: " + moneyAmount + " Beri";
            
        }
        
    }
    

}
