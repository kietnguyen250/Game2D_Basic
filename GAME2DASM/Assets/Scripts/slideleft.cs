using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideleft : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*10*Time.deltaTime);
    }
}
