using UnityEngine;
using UnityEngine.UI;

public class ClickableImage : MonoBehaviour
{
    public bool isCorrect;
    public QuizManager manager;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            manager.TryAnswer(isCorrect);
        });
    }
}
