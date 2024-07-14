using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgrooundRenderer;

    // Update is called once per frame
    void Update()
    {
        backgrooundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime , 0f);
    }
}
