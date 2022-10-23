using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-0.01f, 0, 0));
        transform.Rotate(new Vector3(0, 0.08f, 0));
    }
}
