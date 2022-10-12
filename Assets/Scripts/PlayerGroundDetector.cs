using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundDetector : MonoBehaviour
{
    public PlayerController Player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y - 0.2f, Player.transform.position.z);

    }
    public void OnTriggerStay (Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            if (Input.GetKey("space"))
            {
                if (Input.GetKey("space"))
                {
                    Player.rb.AddForce(new Vector3(0.0f, 2.0f, 0.0f), ForceMode.Impulse);
                }
            }
        }
    }
}
