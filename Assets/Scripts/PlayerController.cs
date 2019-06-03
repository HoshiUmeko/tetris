using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(this.transform.position.x >= -5)
            {
                this.transform.Translate(-1f, 0f, 0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (this.transform.position.x <= 5)
            {
                this.transform.Translate(1f, 0f, 0f);
            }
        }
        
    }
        
}