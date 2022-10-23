using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float vel = 0.1f;
    public Renderer background;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(vel * Time.deltaTime, 0);
        background.material.mainTextureOffset += offset;


    }
}
