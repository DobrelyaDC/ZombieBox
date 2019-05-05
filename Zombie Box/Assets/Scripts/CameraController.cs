using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    public Transform Enemy;

    private Vector3 center;

    private void Start()
    {
    }
    void FixedUpdate()
    {
        center = ((Enemy.position - Player.position) / 2.0f) + Player.position;
        transform.LookAt(center);
        transform.position = Player.transform.position + new Vector3(0f, 40.2f, -50f);
    }
}
