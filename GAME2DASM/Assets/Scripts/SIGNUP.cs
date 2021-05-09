using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SIGNUP : MonoBehaviour
{
    public InputField ID;
    public InputField USERNAME;
    public InputField PASSWORD;
    public InputField LEVEL;
    public InputField POINT;

    string signupPHP = "http://localhost/PHP/signup.php";

    public void login(){
        StartCoroutine(connectserver());
    }

    IEnumerator connectserver(){
        WWWForm wf = new WWWForm();
        wf.AddField("id", ID.text);
        wf.AddField("username", USERNAME.text);
        wf.AddField("password", PASSWORD.text);
        wf.AddField("level", LEVEL.text);
        wf.AddField("point", POINT.text);

        WWW w = new WWW(signupPHP, wf);

        yield return w;

        string tam = w.text;
        string tam1 = tam.TrimStart();
        string tam2 = tam1.TrimEnd();

        

        if(tam2 == "thanhcong"){
            print("Dang ki thanh cong");
        }
        else{
            print("Dang ki that bai");
        }
    }
    
}
