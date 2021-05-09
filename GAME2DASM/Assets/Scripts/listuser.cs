using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listuser : MonoBehaviour
{

    public GameObject rownew;
    string URL="http://localhost/Lab3/showuser.php";


    // Start is called before the first frame update
    void Start()
    {
        getdata();
    }

    public void getdata(){
        StartCoroutine(connect());
    }

    IEnumerator connect(){
        WWWForm wf = new WWWForm();
        WWW w = new WWW(URL, wf);
        yield return w;
        string data = w.text;
        // data = "12345-Top.Killer.1-baonguyen-3-0-,12500-Sushiii-lili1810-9-9-,13478-TiCoNuongg-keokiet250-5-1-,14725-Namkhung-namkhung-2-0-,15762-kietsod150-kietsod250-15-5-,23464-Just Kill One-dinhthai123-1-0-,T15034-Meliodas-meliodax-100-2-,"

        //khai báo mảng để lưu trữ
        string[] a = new string[]{};
        a = data.Split(',');
        //dùng vòng lặp để lấy dữ liệu
        for(int i=0; i<(a.Length)-1; i++){
            string row = a[i];

            string[] b = new string[]{};
            b = row.Split('-');

            GameObject g = (GameObject)Instantiate(rownew);
            g.transform.SetParent(this.transform);

            g.transform.Find("id").GetComponent<Text>().text=b[0];
            g.transform.Find("user_name").GetComponent<Text>().text=b[1];
            g.transform.Find("password").GetComponent<Text>().text=b[2];
            g.transform.Find("level").GetComponent<Text>().text=b[3];
            g.transform.Find("point").GetComponent<Text>().text=b[4];


        }
    }

    
}
