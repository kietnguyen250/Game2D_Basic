using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPlay : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //onClick button Play
    public void PlayBtn()
    {
        SceneManager.LoadScene("Scenes/Game1");

    }
    public void Repeat()
    {
        SceneManager.LoadScene("Scenes/Game1");

    }
    public void Home()
    {
        SceneManager.LoadScene("Scenes/MainMenu");

    }
    public void Shop()
    {
        SceneManager.LoadScene("Scenes/ShopScene");

    }

    public void SignUp()
    {
        SceneManager.LoadScene("Scenes/SampleScene");

    }

    public void User()
    {
        SceneManager.LoadScene("Scenes/User");

    }
}
