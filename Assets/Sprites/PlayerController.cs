using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform playerTransform;
    private float directionX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        directionX = Input.GetAxisRaw("Horizontal");
    }

    // Fixed update is called 50 times per seconds
    void FixedUpdate()
    {
        switch(directionX)
        {
            case 1:
                playerTransform.position = new Vector2(2, -3.25F);
                break;
            case 0:
                playerTransform.position = new Vector2(0, -3.25F);
                break;
            case -1:
                playerTransform.position = new Vector2(-2, -3.25F);
                break;
        }
    }
}
