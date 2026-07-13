using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void GoToGameMain()
    {
        SceneManager.LoadScene("GameMain");
    }
}
