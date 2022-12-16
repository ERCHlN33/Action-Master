using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float runSpeed;
    [SerializeField]
    private float rightLeftSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }
    void Move()
    {
        float Horizontal = Input.GetAxis("Horizontal") * rightLeftSpeed * Time.deltaTime;
        this.transform.Translate(Horizontal, 0, runSpeed * Time.deltaTime);
    }
}
