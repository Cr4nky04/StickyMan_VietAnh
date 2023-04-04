using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : Character
{
    
    
    
   
    
    

    private Vector3 target;
    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 direction;
    private float hDistance;
    private float vDistance;
    
    private bool isDragging;
    

    private void Start()
    {
        n = Random.RandomRange(0, 3);
        Renderer renderer = GetComponent<Renderer>();
        if (n == 0)
        {
            renderer.material.color = Color.green;
        }
        if (n == 1)
        {
            renderer.material.color = Color.blue;
        }
        if (n == 2)
        {
            renderer.material.color = Color.red;
        }
    }
    private void Update()
    {
       
        //Move();
        //if(EatBrick.Count > 0)
        // {
        //     CheckBridge();
        // }

    }


    //private void Move()
    //{
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        startPos = Input.mousePosition;
    //        isDragging = true;
    //    }
    //    if(Input.GetMouseButtonUp(0))
    //    {
    //        isDragging = false;
    //    }
    //    if(isDragging)
    //    {
    //        endPos = Input.mousePosition;
    //        hDistance = endPos.x - startPos.x;
    //        vDistance = endPos.y - startPos.y;
    //        direction = new Vector3(hDistance, 0f, vDistance);
    //        target = transform.position + direction;
    //        player.velocity = direction * speed * Time.deltaTime;
    //        Debug.Log("Move");
    //        player.transform.LookAt(target);
    //    }
    //}

    
    //private void CheckBridge()
    //{
    //    RaycastHit hit;
    //    Debug.DrawRay(transform.position, Vector3.down * 100f, Color.red);
    //    if (Physics.Raycast(transform.position + Vector3.up * 0.5f, Vector3.down, out hit, 100f, bridgeLayer))
    //    {
    //        Debug.Log("Active");
    //        GameObject gameObject = hit.collider.gameObject;
    //        Instantiate(bridgeBrick, gameObject.transform.position + Vector3.up, Quaternion.identity);
    //        gameObject.SetActive(false);
    //        RemoveBrick();
    //    }

    //}

    

    
}

