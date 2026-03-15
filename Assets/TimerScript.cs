using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float timer = 5f;
    public Text timerText;
    public Button next;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Round(timer).ToString();
        if (timer <= 0f)
        {
            timer = 0f;
            timerText.text = "Game Over!!!!";
            // You can add any additional logic here when the timer reaches zero, such as ending the game or triggering an event.
        }
    }
}
