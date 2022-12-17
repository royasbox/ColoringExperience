using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        // Find the start button object and get its Button component
        startButton = GameObject.FindGameObjectWithTag("StartButton").GetComponent<Button>();

        // If the start button object was not found, log an error message and return
        if (startButton == null)
        {
            Debug.LogError("No object tagged as start button!");
            return;
        }

        // Add a listener for the click event on the start button
        startButton.onClick.AddListener(StartDrawing);
    }

    // Load the scene for the drawing when the start button is clicked
    public void StartDrawing()
    {
        SceneManager.LoadScene(1);
    }
}
