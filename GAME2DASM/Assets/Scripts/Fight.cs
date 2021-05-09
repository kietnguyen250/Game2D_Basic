using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fight : MonoBehaviour
{
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        ani.SetBool("dead", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("enemy"))
        {
            AudioManager.instance.PlaySound(AudioManager.instance.dead, 1f);
            ani.SetBool("dead", true);
            ani.Play("die");
            Destroy(gameObject);
            SceneManager.LoadScene("Scenes/GameOver");
        }
        else if(collision.gameObject.CompareTag("kill"))
        {   
            // ani.SetBool("dead", true);
            // ani.Play("die");
            Destroy(collision.gameObject);
            
        }
        
    }
    
}
