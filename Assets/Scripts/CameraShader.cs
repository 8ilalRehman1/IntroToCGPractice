using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShader : MonoBehaviour
{
    public Material NormalLUT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, NormalLUT);
        //Copies source texture into destination render texture with a shader,
        //this is mostly used for implementing post-processing effects
        //the currentLUT changes which makes the colour gradient change
    }
}
