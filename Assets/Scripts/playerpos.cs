using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class playerpos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Shader.SetGlobalVector("_PlayerPos", transform.position);
        
    }
}
