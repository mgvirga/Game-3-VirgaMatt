using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_Menu : MonoBehaviour
{
    public Button startText;

    // Use this for initialization
    void Start()
    {
        startText = startText.GetComponent<Button>();
    }

    // Update is called once per frame
    public void ExitPress()
    {
        startText.enabled = false;
    }
    public void NoPress()
    {
        startText.enabled = true;
    }
    public void StartLevel()
    {
        SceneManager.LoadScene(1);
    }
}
