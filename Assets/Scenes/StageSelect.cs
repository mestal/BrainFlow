using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadSceneAsync("Tangram");
        }
    }
}
