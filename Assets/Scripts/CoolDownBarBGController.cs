using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownBarBGController : MonoBehaviour
{
    private float CoolDownBarBGTimer = 0;
    private Vector3 StartScale;


    // Start is called before the first frame update
    void Start()
    {
        StartScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (CoolDownBarBGTimer > 0)  
            CoolDownBarBGTimer -= Time.deltaTime; 

        if (Input.GetKey("mouse 0"))
            CoolDownBarBGTimer = 3;

        if (CoolDownBarBGTimer <= 0)
            transform.localScale = new Vector3(0,0,0);
        else
            transform.localScale = StartScale;
    }
}
