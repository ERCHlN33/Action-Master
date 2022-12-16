using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject Target;
    public Vector3 offSet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, Target.transform.position+offSet, Time.deltaTime);
    }
}
