using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float timeOut = 1;
    private float speed = 1;
    private float timeElapsed = 0;
    private float _blockStayTime = 0;

    private Vector2 _blockPos;

    private bool _collisionRight = false;
    private bool _collisionLeft = false;
    private bool _collisionUnder = false;

    // Start is called before the first frame update
    void Start()
    {

        _blockPos = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        _blockStayTime += Time.deltaTime;


        if (timeElapsed >= timeOut * speed)
        {
            if (_collisionUnder == false)
            {
                this.transform.Translate(0f, -1f, 0f, Space.World);
            }

            timeElapsed = 0.0f;
        }

        LeftMoveBlock();
        RightMoveBlock();
        DownMoveBlock();
        RotateBlock();

        BlockFixed();
    }

    private void LeftMoveBlock()
    {

        if (_collisionLeft == false)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                this.transform.Translate(-1f, 0f, 0f, Space.World);

            }
        }
    }

    private void RightMoveBlock()
    {
        if (_collisionRight == false)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                this.transform.Translate(1f, 0f, 0f, Space.World);

            }
        }
    }

    private void DownMoveBlock()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (_collisionUnder == false)
            {
                this.transform.Translate(0, -1f, 0f, Space.World);
            }
        }
    }

    private void RotateBlock()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.Rotate(0.0f, 0.0f, 90.0f);
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Flame_Right")
        {
            _collisionRight = true;
        }
        if (col.gameObject.name == "Flame_Left")
        {
            _collisionLeft = true;
        }
        if (col.gameObject.name == "Flame_Under" || col.gameObject.tag == "Block")
        {
            _collisionUnder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Flame_Right")
        {
            _collisionRight = false;
        }
        if (col.gameObject.name == "Flame_Left")
        {
            _collisionLeft = false;
        }
        if (col.gameObject.name == "Flame_Under" || col.gameObject.tag == "Block")
        {
            _collisionUnder = false;
        }

    }

    private void BlockFixed()
    {

        if (_blockPos.y != this.transform.position.y)
        {
            _blockStayTime = 0.0f;

            _blockPos = this.transform.position;

        }

        if (_blockStayTime >= 3.0f)
        {
            Destroy(this);
        }
    }

    private void Clamp()
    {
        Vector2 pos = this.transform.position;

        pos.x = Mathf.Clamp(pos.x, -5.0f, 5.0f);
        pos.y = Mathf.Clamp(pos.y, -10.0f, 10.0f);

        transform.position = new Vector2(pos.x, pos.y);
    }
}