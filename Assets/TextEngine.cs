using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TextEngine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string[] sentences;
    private int index = 0;
    public Text text;
    public GameObject dialogue;
    public Button nextButton;
    private int currentSceneIndex = 0;
    void Start()
    {
    }
    public void NextSentence()
        {
        print("Next Sentence");
        if (index < sentences.Length - 1)
        {
            index++;
            text.text = sentences[index];
            //dialogue.text = sentences[index];
        }
        else
        {             
            index = 0;
            dialogue.SetActive(false);
        }   
    }

    public void printStatus()
        {
        print("Click");
    }
    // Update is called once per frame
    void Update()
    {
        text.text = sentences[index];
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextSentence();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            currentSceneIndex++;
            SceneManager.LoadScene(currentSceneIndex);
        }
    }



}
