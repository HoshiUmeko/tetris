using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float timeOut = 1;
    private float speed = 1;
    private float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut * speed)
        {
            this.transform.Translate(0f, -1f, 0f, Space.World);

            timeElapsed = 0.0f;
        }

        LeftMoveBlock();
        RightMoveBlock();
        RotateBlock();

    }

    private void LeftMoveBlock()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (this.transform.position.x >= -5)
            {
                this.transform.Translate(-1f, 0f, 0f, Space.World);
            }
        }
    }

    private void RightMoveBlock()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (this.transform.position.x <= 5)
            {
                this.transform.Translate(1f, 0f, 0f, Space.World);
            }
        }
    }
    
    private void RotateBlock()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.Rotate(0, 0, 90);
        }

    }
}