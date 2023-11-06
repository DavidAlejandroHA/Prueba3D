using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public GameObject cubo;
    public float offsetZ, offsetY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cubo.transform.position.x, cubo.transform.position.y - offsetY, cubo.transform.position.z - offsetZ);
    }
}
