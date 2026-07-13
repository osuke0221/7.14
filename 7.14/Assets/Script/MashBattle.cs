using UnityEngine;
using UnityEngine.UI;

public class MashBattle : MonoBehaviour
{
    public Slider playerGauge;
    public Slider npcGauge;

    public float npcSpeedMin = 0.2f;
    public float npcSpeedMax = 0.5f;

    float npcSpeed;
    bool gameEnded = false;

    public QuizManager quizManager;

    void Start()
    {
        npcSpeed = Random.Range(npcSpeedMin, npcSpeedMax);

        if (quizManager == null)
        {
            quizManager = FindObjectOfType<QuizManager>();
        }
    }

    void Update()
    {
        if (gameEnded) return;  // ★勝負が終わったら完全停止

        // プレイヤー連打
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerGauge.value += 0.05f;
        }

        // NPC自動上昇
        npcGauge.value += npcSpeed * Time.deltaTime;

        // 勝敗判定
        if (playerGauge.value >= 1f)
        {
            gameEnded = true;
            quizManager.GiveAnswerRight();  // ★正解ボタンが押せるようになる
        }
        else if (npcGauge.value >= 1f)
        {
            gameEnded = true;
            quizManager.NoAnswerRight();    // ★ゲームオーバーへ
        }
    }
}
