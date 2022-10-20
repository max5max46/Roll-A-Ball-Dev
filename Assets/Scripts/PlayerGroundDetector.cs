using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundDetector : MonoBehaviour
{
    public PlayerController Player;
    int JumpFix = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y - 0.2f, Player.transform.position.z);
    }
    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            JumpFix += 1;
        }

        if (JumpFix <= 0)
            Player.IsOnGround = false;
        else
            Player.IsOnGround = true;
    }

    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Ground"))
        {
            JumpFix -= 1;
        }

        if (JumpFix <= 0)
            Player.IsOnGround = false;
        else
            Player.IsOnGround = true;
    }

}
