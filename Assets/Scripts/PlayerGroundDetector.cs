using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundDetector : MonoBehaviour
{
    public PlayerController Player;
    private bool IsSpacePressed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y - 0.2f, Player.transform.position.z);
        if (Input.GetKeyDown("space"))
            IsSpacePressed = true;
    }
    public void OnTriggerStay (Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            if (IsSpacePressed == true)
            {
                Player.rb.AddForce(new Vector3(0.0f, 7.0f, 0.0f), ForceMode.Impulse);
                IsSpacePressed = false;
            }
        }
    }
}
