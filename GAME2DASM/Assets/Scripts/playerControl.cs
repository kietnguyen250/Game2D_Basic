using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    //khai báo đối tượng
    public Animator ani;
    Rigidbody2D rigidbody2D;
    public float speed = 1;
    public float hight = 5;
    
    
    // Start is called before the first frame update
    void Start()
    {

        AudioManager.instance.PlaySound(AudioManager.instance.theme, 1f, true);
        // rigidbody2D = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        ani.SetBool("runing", false);
        
    }

    void FixedUpdate(){
        
        // else if (Input.GetKey(KeyCode.))
        // {
        //     transform.localScale = new Vector(1, 2);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(-3F, 2.5F, 0);
            ani.SetBool("runing", true);
            ani.Play("run");
            transform.Translate(Time.deltaTime * -1 * speed, 0, 0);
            // transform.localScale = new Vector3(-1, 1);
            // rigidbody2D.AddForce(new Vector2(-1 * speed, 0));
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                ani.SetBool("jumping", true);
                ani.SetBool("runing", false);
                ani.Play("jump");
                transform.Translate(Time.deltaTime * -1, Time.deltaTime * 7, 0);
                
                // rigidbody2D.AddForce(new Vector2(1 * speed, 0));
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(3F, 2.5F, 0);
            ani.SetBool("runing", true);
            ani.Play("run");
            transform.Translate(Time.deltaTime * 1 * speed, 0, 0);
            
            // rigidbody2D.AddForce(new Vector2(1 * speed, 0));
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                ani.SetBool("jumping", true);
                ani.SetBool("runing", false);
                ani.Play("jump");
                transform.Translate(Time.deltaTime * 1, Time.deltaTime * 7, 0);
                // transform.localScale = new Vector3(1, 1);
                // rigidbody2D.AddForce(new Vector2(1 * speed, 0));
            }
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            ani.SetBool("jumping", true);
            ani.Play("jump");
            transform.Translate(0, Time.deltaTime * 7, 0);
            // transform.localScale = new Vector3(1, 1);
            // rigidbody2D.AddForce(new Vector2(1 * speed, 0));
        }
        else
        {
            ani.SetBool("runing", false);
            ani.SetBool("jumping", false);
            ani.Play("idle");
        }
    }
}
