using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> drawings;

    public void OnDrawingFound(GameObject foundDrawing)
    {
        // Remove the found drawing from the list of drawings
        drawings.Remove(foundDrawing);

        // If there are no more drawings, load the next scene
        if (drawings.Count == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
