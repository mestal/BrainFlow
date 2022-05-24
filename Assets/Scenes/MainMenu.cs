using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadSceneAsync("Menu");
        }
    }
}
