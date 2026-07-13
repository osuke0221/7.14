using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public bool canAnswer = false;

    public Button correctButton;
    public Button wrongButton;

    void Start()
    {
        // Å‰‚Í‰Ÿ‚¹‚È‚¢
        correctButton.interactable = false;
        wrongButton.interactable = false;
    }

    public void GiveAnswerRight()
    {
        canAnswer = true;

        // šŸ‚Á‚½‚ç³‰ğEŠÔˆá‚¦ƒ{ƒ^ƒ“‚ğ‰Ÿ‚¹‚é‚æ‚¤‚É‚·‚é
        correctButton.interactable = true;
        wrongButton.interactable = true;
    }

    public void NoAnswerRight()
    {
        canAnswer = false;
        SceneManager.LoadScene("GameOver");
    }

    public void TryAnswer(bool isCorrect)
    {
        if (!canAnswer)
        {
            SceneManager.LoadScene("GameOver");
            return;
        }

        if (isCorrect)
        {
            SceneManager.LoadScene("Result");
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
