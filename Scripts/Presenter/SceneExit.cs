using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneExit : MonoBehaviour
{
    public void OnEnd()
    {
        SceneManager.LoadScene(0);
    }
    public void OnError()
    {
        SceneManager.LoadScene(3);
    }
}
