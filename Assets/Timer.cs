using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f;
    private Label timerLabel;
    private bool isTimmerRunning = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        timerLabel = root.Q<Label>("Timer");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimmerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else 
            {
                timeRemaining = 0;
                isTimmerRunning = false;
                OnTimerEnd();
            }
        }
        
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

         timerLabel.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void OnTimerEnd()
    {
        timerLabel.text = "TIME'S UP!";
    }


}
