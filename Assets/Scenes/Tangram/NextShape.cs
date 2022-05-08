using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextShape : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetNextShape();
        }
    }

    public static void SetNextShape()
    {
        if(GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber == 8)
        {
            GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber = 1;
        }
        else { 
            GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber++;
        }
        if (GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber == 1)
        {
            GameObject.Find("01 - square_empty").transform.position = new Vector3(0, 3.75f, 0);
            GameObject.Find("01 - square_empty").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("01 - square_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 2, 4, 6, 8 };

            GameObject.Find("03 - triangle1_empty - 1").transform.position = new Vector3(1.02f, 2.05f, 0);
            GameObject.Find("03 - triangle1_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, -90);
            GameObject.Find("03 - triangle1_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 3 };

            GameObject.Find("11 - paralel_empty").transform.position = new Vector3(1.4f, 1.87f, 0);
            GameObject.Find("11 - paralel_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("11 - paralel_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 5 };

            GameObject.Find("03 - triangle1_empty - 2").transform.position = new Vector3(-0.69f, 0.3f, 0);
            GameObject.Find("03 - triangle1_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 90);
            GameObject.Find("03 - triangle1_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 7 };

            GameObject.Find("09 - triangle3_empty").transform.position = new Vector3(0.33f, -0.09f, 0);
            GameObject.Find("09 - triangle3_empty").transform.localRotation = Quaternion.Euler(0, 0, 135);
            GameObject.Find("09 - triangle3_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 6 };

            GameObject.Find("06 - triangle2_empty - 1").transform.position = new Vector3(0.55f, -1.58f, 0);
            GameObject.Find("06 - triangle2_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, -45);
            GameObject.Find("06 - triangle2_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 2 };

            GameObject.Find("06 - triangle2_empty - 2").transform.position = new Vector3(-1.83f, -1.21f, 0);
            GameObject.Find("06 - triangle2_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, -90);
            GameObject.Find("06 - triangle2_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 3 };
        }
        else if (GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber == 2)
        {
            GameObject.Find("01 - square_empty").transform.position = new Vector3(-0.51f, 2.13f, 0);
            GameObject.Find("01 - square_empty").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("01 - square_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 2, 4, 6, 8 };

            GameObject.Find("03 - triangle1_empty - 1").transform.position = new Vector3(-2.8f, 1.13f, 0);
            GameObject.Find("03 - triangle1_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("03 - triangle1_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 7, 8 };

            GameObject.Find("11 - paralel_empty").transform.position = new Vector3(-0.87f, 3.15f, 0);
            GameObject.Find("11 - paralel_empty").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("11 - paralel_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 4, 8 };

            GameObject.Find("03 - triangle1_empty - 2").transform.position = new Vector3(-1.81f, 0.71f, 0);
            GameObject.Find("03 - triangle1_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 90);
            GameObject.Find("03 - triangle1_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 7, 8 };

            GameObject.Find("09 - triangle3_empty").transform.position = new Vector3(-0.79f, 0.72f, 0);
            GameObject.Find("09 - triangle3_empty").transform.localRotation = Quaternion.Euler(0, 0, 135);
            GameObject.Find("09 - triangle3_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 6 };

            GameObject.Find("06 - triangle2_empty - 1").transform.position = new Vector3(-0.02f, 3.7f, 0);
            GameObject.Find("06 - triangle2_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("06 - triangle2_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 2 };

            GameObject.Find("06 - triangle2_empty - 2").transform.position = new Vector3(0.2f, 1.42f, 0);
            GameObject.Find("06 - triangle2_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, -45);
            GameObject.Find("06 - triangle2_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 2 };
        }
        else if (GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber == 3)
        {
            GameObject.Find("01 - square_empty").transform.position = new Vector3(-1.58f, 2.88f, 0);
            GameObject.Find("01 - square_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("01 - square_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 3, 5, 7 };

            GameObject.Find("03 - triangle1_empty - 1").transform.position = new Vector3(-0.07f, -0.31f, 0);
            GameObject.Find("03 - triangle1_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 180);
            GameObject.Find("03 - triangle1_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 5 };

            GameObject.Find("11 - paralel_empty").transform.position = new Vector3(-0.57f, 3.86f, 0);
            GameObject.Find("11 - paralel_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("11 - paralel_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 5 };

            GameObject.Find("03 - triangle1_empty - 2").transform.position = new Vector3(-0.07f, 1.71f, 0);
            GameObject.Find("03 - triangle1_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("03 - triangle1_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 5 };

            GameObject.Find("09 - triangle3_empty").transform.position = new Vector3(0.21f, -0.62f, 0);
            GameObject.Find("09 - triangle3_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("09 - triangle3_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1 };

            GameObject.Find("06 - triangle2_empty - 1").transform.position = new Vector3(-0.49f, -0.62f, 0);
            GameObject.Find("06 - triangle2_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, -45);
            GameObject.Find("06 - triangle2_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 2 };

            GameObject.Find("06 - triangle2_empty - 2").transform.position = new Vector3(-1.05f, 0.73f, 0);
            GameObject.Find("06 - triangle2_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, -45);
            GameObject.Find("06 - triangle2_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 2 };
        }
        else if (GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber == 4)
        {
            GameObject.Find("01 - square_empty").transform.position = new Vector3(0.07f, 2.87f, 0);
            GameObject.Find("01 - square_empty").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("01 - square_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 2, 4, 6, 8 };

            GameObject.Find("03 - triangle1_empty - 1").transform.position = new Vector3(0.79f, 1.48f, 0);
            GameObject.Find("03 - triangle1_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, -45);
            GameObject.Find("03 - triangle1_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 2, 3 };

            GameObject.Find("11 - paralel_empty").transform.position = new Vector3(1.15f, 2.55f, 0);
            GameObject.Find("11 - paralel_empty").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("11 - paralel_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 4, 8 };

            GameObject.Find("03 - triangle1_empty - 2").transform.position = new Vector3(-0.97f, 1.19f, 0);
            GameObject.Find("03 - triangle1_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 270);
            GameObject.Find("03 - triangle1_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 3 };

            GameObject.Find("09 - triangle3_empty").transform.position = new Vector3(-0.96f, 2.17f, 0);
            GameObject.Find("09 - triangle3_empty").transform.localRotation = Quaternion.Euler(0, 0, -135);
            GameObject.Find("09 - triangle3_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 4 };

            GameObject.Find("06 - triangle2_empty - 1").transform.position = new Vector3(0.8f, 3.55f, 0);
            GameObject.Find("06 - triangle2_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 135);
            GameObject.Find("06 - triangle2_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 6, 8 };

            GameObject.Find("06 - triangle2_empty - 2").transform.position = new Vector3(1.52f, 4.24f, 0);
            GameObject.Find("06 - triangle2_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("06 - triangle2_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 6, 8 };
        }
        else if (GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber == 5)
        {
            GameObject.Find("01 - square_empty").transform.position = new Vector3(0f, 3.1f, 0);
            GameObject.Find("01 - square_empty").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("01 - square_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 2, 4, 6, 8 };

            GameObject.Find("03 - triangle1_empty - 1").transform.position = new Vector3(0.41f, 0.03f, 0);
            GameObject.Find("03 - triangle1_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 90);
            GameObject.Find("03 - triangle1_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 6, 7 };

            GameObject.Find("11 - paralel_empty").transform.position = new Vector3(2.35f, -0.5f, 0);
            GameObject.Find("11 - paralel_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("11 - paralel_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 5 };

            GameObject.Find("03 - triangle1_empty - 2").transform.position = new Vector3(-0.01f, 1.01f, 0);
            GameObject.Find("03 - triangle1_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 135);
            GameObject.Find("03 - triangle1_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 6, 7 };

            GameObject.Find("09 - triangle3_empty").transform.position = new Vector3(-0.02f, 1.41f, 0);
            GameObject.Find("09 - triangle3_empty").transform.localRotation = Quaternion.Euler(0, 0, 315);
            GameObject.Find("09 - triangle3_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 2 };

            GameObject.Find("06 - triangle2_empty - 1").transform.position = new Vector3(-0.68f, 3.77f, 0);
            GameObject.Find("06 - triangle2_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 135);
            GameObject.Find("06 - triangle2_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 2, 6 };

            GameObject.Find("06 - triangle2_empty - 2").transform.position = new Vector3(0.71f, 3.79f, 0);
            GameObject.Find("06 - triangle2_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, -45);
            GameObject.Find("06 - triangle2_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 2, 6 };
        }
        else if (GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber == 6)
        {
            GameObject.Find("01 - square_empty").transform.position = new Vector3(0f, 3.63f, 0);
            GameObject.Find("01 - square_empty").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("01 - square_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 2, 4, 6, 8 };

            GameObject.Find("03 - triangle1_empty - 1").transform.position = new Vector3(0f, 2.95f, 0);
            GameObject.Find("03 - triangle1_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("03 - triangle1_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 4, 8 };

            GameObject.Find("11 - paralel_empty").transform.position = new Vector3(-1.99f, 0.23f, 0);
            GameObject.Find("11 - paralel_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("11 - paralel_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 5 };

            GameObject.Find("03 - triangle1_empty - 2").transform.position = new Vector3(-0.61f, 0.71f, 0);
            GameObject.Find("03 - triangle1_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, -135);
            GameObject.Find("03 - triangle1_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 4, 8 };

            GameObject.Find("09 - triangle3_empty").transform.position = new Vector3(0.09f, 0f, 0);
            GameObject.Find("09 - triangle3_empty").transform.localRotation = Quaternion.Euler(0, 0, 180);
            GameObject.Find("09 - triangle3_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 5 };

            GameObject.Find("06 - triangle2_empty - 1").transform.position = new Vector3(-3.14f, -0.43f, 0);
            GameObject.Find("06 - triangle2_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 270);
            GameObject.Find("06 - triangle2_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 3 };

            GameObject.Find("06 - triangle2_empty - 2").transform.position = new Vector3(1.01f, -0.93f, 0);
            GameObject.Find("06 - triangle2_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("06 - triangle2_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 3 };
        }
        else if (GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber == 7)
        {
            GameObject.Find("01 - square_empty").transform.position = new Vector3(-2.51f, 2.79f, 0);
            GameObject.Find("01 - square_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("01 - square_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 3, 5, 7 };

            GameObject.Find("03 - triangle1_empty - 1").transform.position = new Vector3(-1.03f, 2.28f, 0);
            GameObject.Find("03 - triangle1_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 180);
            GameObject.Find("03 - triangle1_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 5, 6 };

            GameObject.Find("11 - paralel_empty").transform.position = new Vector3(-1.99f, 1.39f, 0);
            GameObject.Find("11 - paralel_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("11 - paralel_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 5 };

            GameObject.Find("03 - triangle1_empty - 2").transform.position = new Vector3(0f, 1.88f, 0);
            GameObject.Find("03 - triangle1_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 135);
            GameObject.Find("03 - triangle1_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 5, 6 };

            GameObject.Find("09 - triangle3_empty").transform.position = new Vector3(-1.32f, 2.58f, 0);
            GameObject.Find("09 - triangle3_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("09 - triangle3_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1 };

            GameObject.Find("06 - triangle2_empty - 1").transform.position = new Vector3(0.19f, 0.64f, 0);
            GameObject.Find("06 - triangle2_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 90);
            GameObject.Find("06 - triangle2_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 7 };

            GameObject.Find("06 - triangle2_empty - 2").transform.position = new Vector3(-3.49f, 2.8f, 0);
            GameObject.Find("06 - triangle2_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 90);
            GameObject.Find("06 - triangle2_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 7 };
        }
        else if (GameObject.Find("rotateButton").GetComponent<MainControl>().shapeNumber == 8)
        {
            GameObject.Find("01 - square_empty").transform.position = new Vector3(-0.02f, 2.79f, 0);
            GameObject.Find("01 - square_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("01 - square_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 3, 5, 7 };

            GameObject.Find("03 - triangle1_empty - 1").transform.position = new Vector3(-0.07f, 1.32f, 0);
            GameObject.Find("03 - triangle1_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 45);
            GameObject.Find("03 - triangle1_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 4, 8 };

            GameObject.Find("11 - paralel_empty").transform.position = new Vector3(-0.51f, 1.82f, 0);
            GameObject.Find("11 - paralel_empty").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("11 - paralel_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 1, 5 };

            GameObject.Find("03 - triangle1_empty - 2").transform.position = new Vector3(1.36f, -0.1f, 0);
            GameObject.Find("03 - triangle1_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 225);
            GameObject.Find("03 - triangle1_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 4, 8 };

            GameObject.Find("09 - triangle3_empty").transform.position = new Vector3(-0.53f, 3.3f, 0);
            GameObject.Find("09 - triangle3_empty").transform.localRotation = Quaternion.Euler(0, 0, 225);
            GameObject.Find("09 - triangle3_empty").GetComponent<ShapeProperties>().rotation = new List<int>() { 4 };

            GameObject.Find("06 - triangle2_empty - 1").transform.position = new Vector3(-0.47f, -0.65f, 0);
            GameObject.Find("06 - triangle2_empty - 1").transform.localRotation = Quaternion.Euler(0, 0, 90);
            GameObject.Find("06 - triangle2_empty - 1").GetComponent<ShapeProperties>().rotation = new List<int>() { 6, 7 };

            GameObject.Find("06 - triangle2_empty - 2").transform.position = new Vector3(1.39f, -0.8f, 0);
            GameObject.Find("06 - triangle2_empty - 2").transform.localRotation = Quaternion.Euler(0, 0, 135);
            GameObject.Find("06 - triangle2_empty - 2").GetComponent<ShapeProperties>().rotation = new List<int>() { 6, 7 };
        }

        GameObject.Find("02 - square_filled").transform.position = new Vector3(-9.349502f, -2.974842f, 0);
        GameObject.Find("02 - square_filled").transform.localRotation = Quaternion.Euler(0, 0, 0);
        GameObject.Find("02 - square_filled").GetComponent<MoveShape>().rotation = 1;
        GameObject.Find("02 - square_filled").GetComponent<MoveShape>().finish = false;

        GameObject.Find("04 - triangle1_filled").transform.position = new Vector3(-7.299611f, -3.074837f, 0);
        GameObject.Find("04 - triangle1_filled").transform.localRotation = Quaternion.Euler(0, 0, 0);
        GameObject.Find("04 - triangle1_filled").GetComponent<MoveShape>().rotation = 1;
        GameObject.Find("04 - triangle1_filled").GetComponent<MoveShape>().finish = false;

        GameObject.Find("05 - triangle1_filled").transform.position = new Vector3(-4.199776f, -3.074837f, 0);
        GameObject.Find("05 - triangle1_filled").transform.localRotation = Quaternion.Euler(0, 0, 0);
        GameObject.Find("05 - triangle1_filled").GetComponent<MoveShape>().rotation = 1;
        GameObject.Find("05 - triangle1_filled").GetComponent<MoveShape>().finish = false;

        GameObject.Find("07 - triangle2_filled").transform.position = new Vector3(-1.999893f, -3.074837f, 0);
        GameObject.Find("07 - triangle2_filled").transform.localRotation = Quaternion.Euler(0, 0, 0);
        GameObject.Find("07 - triangle2_filled").GetComponent<MoveShape>().rotation = 1;
        GameObject.Find("07 - triangle2_filled").GetComponent<MoveShape>().finish = false;

        GameObject.Find("08 - triangle2_filled").transform.position = new Vector3(0f, -3.074837f, 0);
        GameObject.Find("08 - triangle2_filled").transform.localRotation = Quaternion.Euler(0, 0, 0);
        GameObject.Find("08 - triangle2_filled").GetComponent<MoveShape>().rotation = 1;
        GameObject.Find("08 - triangle2_filled").GetComponent<MoveShape>().finish = false;

        GameObject.Find("10 - triangle3_filled").transform.position = new Vector3(1.799904f, -3.224828f, 0);
        GameObject.Find("10 - triangle3_filled").transform.localRotation = Quaternion.Euler(0, 0, 0);
        GameObject.Find("10 - triangle3_filled").GetComponent<MoveShape>().rotation = 1;
        GameObject.Find("10 - triangle3_filled").GetComponent<MoveShape>().finish = false;

        GameObject.Find("12 - paralel_filled").transform.position = new Vector3(4.399765f, -3.474815f, 0);
        GameObject.Find("12 - paralel_filled").transform.localRotation = Quaternion.Euler(0, 0, 0);
        GameObject.Find("12 - paralel_filled").GetComponent<MoveShape>().rotation = 1;
        GameObject.Find("12 - paralel_filled").GetComponent<MoveShape>().finish = false;

    }
}
