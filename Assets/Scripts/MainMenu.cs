using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartGame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void StartGame3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
