using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject phoneUIPanel;
    public GameObject resultPanel;

    [Header("UI Elements")]
    public Text messageText;
    public Text resultText;
    public Text senderText; 
    public Button spamButton;
    public Button notSpamButton;
    public Button retryButton;
    public Button closeButton;

    [Header("Game Settings")]
    public float timeLimit = 30f;

    private List<(string sender, string message, bool isSpam)> questions = new List<(string, string, bool)>
    {
        ("CommBank ", " We’ve noticed unusual login activity on your account. If this wasn’t you, secure your profile now: commbank-security.com/verify ", false),
        ("AusPost ", "Your delivery is about to be returned due to failed ID check. Confirm now (00:59 left): auspostt.com.au/parcel-return ", true),
        ("VICRoads", "Immediate action required! Your license is at risk of suspension. Verify your details within 60 seconds. viccroads.license.vic.gov.au ", true)
    };

    private int currentQuestionIndex = 0;
    private Coroutine timerCoroutine;

    void Start()
    {
        Debug.Log("Game Started");

        resultPanel.SetActive(false);
        retryButton.gameObject.SetActive(false);
        closeButton.gameObject.SetActive(false);

        spamButton.onClick.AddListener(() => HandleAnswer(true));
        notSpamButton.onClick.AddListener(() => HandleAnswer(false));
        retryButton.onClick.AddListener(RestartGame);
        closeButton.onClick.AddListener(QuitGame);

        ShowQuestion();
    }

    void ShowQuestion()
    {
        if (currentQuestionIndex < questions.Count)
        {
            var question = questions[currentQuestionIndex];
            senderText.text = $"From: {question.sender}";
            messageText.text = question.message;

            phoneUIPanel.SetActive(true);
            resultPanel.SetActive(false);

            timerCoroutine = StartCoroutine(MessageTimer());
        }
        else
        {
            phoneUIPanel.SetActive(false);
            resultPanel.SetActive(true);
            resultText.text = "Quiz complete!";
            retryButton.gameObject.SetActive(true);
            closeButton.gameObject.SetActive(true);
        }
    }

    IEnumerator MessageTimer()
    {
        yield return new WaitForSeconds(timeLimit);
        HandleAnswer(null);
    }

    void HandleAnswer(bool? selectedSpam)
    {

        if (timerCoroutine != null)
        {
            StopCoroutine(timerCoroutine);
        }

        phoneUIPanel.SetActive(false);
        resultPanel.SetActive(true);

        bool correctAnswer = questions[currentQuestionIndex].isSpam;

        if (selectedSpam == null)
        {
            resultText.text = "Time's up! No answer selected.";
        }
        else if (selectedSpam == correctAnswer)
        {
            resultText.text = "Great! You have identified correctly.";
        }
        else
        {
            resultText.text = "Unfortunately! You have identified wrong.";
        }

        currentQuestionIndex++;

        if (currentQuestionIndex >= questions.Count)
        {
            retryButton.gameObject.SetActive(true);
            closeButton.gameObject.SetActive(true);
        }
        else
        {
            StartCoroutine(NextQuestionAfterDelay(2f));
        }
    }

    IEnumerator NextQuestionAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        ShowQuestion();
    }

    void RestartGame()
    {
        currentQuestionIndex = 0;
        retryButton.gameObject.SetActive(false);
        closeButton.gameObject.SetActive(false);
        ShowQuestion();
    }

    void QuitGame()
    {
        Debug.Log("Game Closed.");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
