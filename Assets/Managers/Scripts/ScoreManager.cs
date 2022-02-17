using UnityEngine;
using TMPro;

// Управляет изменением счёта

public class ScoreManager : MonoBehaviour
{
    // Ссылка на шину событий
    [SerializeField] private EventBus eventBus;

    // Ссылка на переменные приложения
    [SerializeField] private AppVariables appVariables;

    // Ссылка на UI текст счёта
    [SerializeField] private TextMeshProUGUI scoreUI;

    // Счёт игры
    private int Score
    {
        get
        {
            return appVariables.score;
        }
        set
        {
            // Счёт не может быть меньше нуля
            int number = value < 0 ? number = 0 : number = value;

            appVariables.score = number;
        }
    }

    // На старте
    private void Start()
    {
        // Подписываемся на событие изменения счёта
        eventBus.scoreChangeEvent.AddListener(ChangeScore);

        // Сбрасываем счёт
        Score = 0;
    }


    // На событии изменения счёта
    private void ChangeScore(int scoreChangeValue)
    {
        Score += scoreChangeValue;

        scoreUI.text = Score.ToString();
    }

    // При уничтожении объекта
    private void OnDestroy()
    {
        // Отписываемся от события изменения счёта
        eventBus.scoreChangeEvent.RemoveListener(ChangeScore);
    }
}
