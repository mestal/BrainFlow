using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    public GameObject activeShape;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(activeShape != null)
            {
                activeShape.transform.Rotate(0, 0, -45);
                if(activeShape.GetComponent<MoveShape>().rotation == 8)
                {
                    activeShape.GetComponent<MoveShape>().rotation = 1;
                }
                else { 
                    activeShape.GetComponent<MoveShape>().rotation++;
                }
            }
        }
    }
}
