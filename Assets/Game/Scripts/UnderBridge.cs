using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class UnderBridge : MonoBehaviour
{
    [SerializeField] private Rigidbody player;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private GameObject checkForward;

    private Vector3 boundaryPoint;


    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<MeshRenderer>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        Build();
    }

    private void Build()
    {

        RaycastHit hit;
        if (Physics.Raycast(player.transform.position, Vector3.down, out hit, 2f, layerMask))
        {
            if (hit.collider.gameObject.transform.position == transform.position && transform.GetComponent<MeshRenderer>().enabled == false)
            {
                if(player.GetComponent<Character>().EatBrick.Count != 0)
                {
                    Debug.Log("1");
                    transform.GetComponent<MeshRenderer>().enabled = true;
                    player.GetComponent<Character>().RemoveBrick();
                    boundaryPoint = player.transform.position;
                    Debug.Log(boundaryPoint);
                }

                else
                {
                    if(player.transform.position.y>boundaryPoint.y)
                    {
                        player.transform.position = boundaryPoint;
                    }
                    if(player.transform.position.z>boundaryPoint.z)
                    {
                        player.transform.position = boundaryPoint;
                    }

                }

            }



        }
    }
}
