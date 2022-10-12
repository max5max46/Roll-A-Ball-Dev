using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDetectorScript : MonoBehaviour
{
    private Vector3 offset;

    public GameObject player;
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (new Vector3(player.transform.position.x, player.transform.position.y + 23.6f, player.transform.position.z) + offset);
    }
}
