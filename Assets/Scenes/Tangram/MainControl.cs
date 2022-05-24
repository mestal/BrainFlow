using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    public GameObject activeShape;
    public int shapeNumber;
    public int shapePoint;

    void Start()
    {
        shapeNumber = 0;
        shapePoint = 0;
        NextShape.SetNextShape();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(activeShape != null)
            {
                GameObject.Find("rotateButton").GetComponent<PlaySounds>().Rotate();
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
