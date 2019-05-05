using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class GameController : MonoBehaviour
{

    Transform player;               // Reference to the player's position.
    NavMeshAgent nav;               // Reference to the nav mesh agent.


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }
    void FixedUpdate()
    {
        nav.SetDestination(player.position);
        int layerMask = 1 << 8;

        layerMask = ~layerMask;
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15f, layerMask))
        {
            Renderer rend = hit.transform.GetComponent<Renderer>();
            BoxCollider coll = hit.transform.GetComponent<BoxCollider>();
            if (hit.transform.name == "Player" || hit.transform.name == "Board")
            {

            }
            else
            {
                coll.isTrigger = true;
                rend.material.shader = Shader.Find("Transparent/Diffuse");
                Color tempColor = rend.material.color;
                tempColor.a = 0.3F;
                rend.material.color = tempColor;
            }
        }
        else
        {
            Debug.Log("Did not Hit");
        }
    }
}
