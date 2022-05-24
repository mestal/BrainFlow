using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShape : MonoBehaviour
{
    public List<GameObject> correctForms;

    public Sprite imageBold;
    public Sprite imageDefault;

    public int rotation;
    private bool moving;
    public bool finish;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;

    // Start is called before the first frame update
    void Start()
    {
        rotation = 1;
        resetPosition = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (finish == false)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GameObject.Find("rotateButton").GetComponent<MainControl>().activeShape != null)
            {
                GameObject.Find("rotateButton").GetComponent<MainControl>().activeShape.GetComponent<SpriteRenderer>().sprite =
                    GameObject.Find("rotateButton").GetComponent<MainControl>().activeShape.GetComponent<MoveShape>().imageDefault;
            }

            GameObject.Find("rotateButton").GetComponent<PlaySounds>().Selected();
            GameObject.Find("rotateButton").GetComponent<MainControl>().activeShape = this.gameObject;

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            GetComponent<SpriteRenderer>().sortingLayerName = "Tangram_selected";
            GetComponent<SpriteRenderer>().sprite = imageBold;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;
        GetComponent<SpriteRenderer>().sortingLayerName = "Tangram_filled";
        foreach (var correctForm in correctForms)
        {
            if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f
                && Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.5f
                && correctForm.GetComponent<ShapeProperties>().rotation.Contains(this.rotation))
            {
                this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
                finish = true;
                GameObject.Find("rotateButton").GetComponent<MainControl>().activeShape = null;
                GetComponent<SpriteRenderer>().sprite = imageDefault;
                GameObject.Find("rotateButton").GetComponent<MainControl>().shapePoint++;
                if (GameObject.Find("rotateButton").GetComponent<MainControl>().shapePoint == 7)
                {
                    GameObject.Find("rotateButton").GetComponent<MainControl>().shapePoint = 0;
                    GameObject.Find("rotateButton").GetComponent<PlaySounds>().Congrats();
                    Invoke("NextShapeCall", 4f);

                }
                else
                {
                    GameObject.Find("rotateButton").GetComponent<PlaySounds>().CorrectMove();
                }
                return;
            }
        }

        if (Mathf.Abs(this.transform.localPosition.x - resetPosition.x) > 0.5f ||
            Mathf.Abs(this.transform.localPosition.y - resetPosition.y) > 0.5f ||
            Mathf.Abs(this.transform.localPosition.z - resetPosition.z) > 0.5f)
        {
            GameObject.Find("rotateButton").GetComponent<PlaySounds>().WrongMove();
        }

        this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);

    }

    void NextShapeCall()
    {
        NextShape.SetNextShape();
    }
}
