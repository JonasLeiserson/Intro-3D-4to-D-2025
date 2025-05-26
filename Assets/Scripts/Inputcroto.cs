using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputcroto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.C))
        {
            gameObject.transform.Translate(-35 * Time.deltaTime, 0, 0);
        }
    }
}
