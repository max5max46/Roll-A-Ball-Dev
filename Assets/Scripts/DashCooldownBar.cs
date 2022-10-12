using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DashCooldownBar : MonoBehaviour
{
    public PlayerController Player;
    private Vector3 StartScale;

    // Start is called before the first frame update
    void Start()
    {
        StartScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(StartScale.x * (Player.CoolDown * 1.42857143f), StartScale.y, StartScale.z);
    }
}
