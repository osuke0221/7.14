using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void GoToRetry()
    {
        SceneManager.LoadScene("StartScene");
    }
}
