using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public GameObject Arrow;
    public GameObject CooldownBar;
    public GameObject CooldownBarBG;
    public PlayerController Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerGuy"))
        {
            gameObject.SetActive(false);
            CooldownBar.SetActive(true);
            CooldownBarBG.SetActive(true);
            Arrow.SetActive(true);
            Player.CanDash = true;
        }
    }
}
