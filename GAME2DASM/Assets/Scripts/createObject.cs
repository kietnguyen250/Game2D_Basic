using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createObject : MonoBehaviour
{
    public GameObject taomoi;
    public GameObject start_location;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(tao());
    }

    IEnumerator tao()
    {
        yield return new WaitForSeconds(1f);

        Vector3 temp = start_location.transform.position;
        temp.y = Random.Range(-14f, -2f);

        Instantiate(taomoi, temp, Quaternion.identity);
        StartCoroutine(tao());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
