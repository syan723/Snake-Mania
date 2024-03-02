using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointsText;
    SnakeManager gameManager;

    int previousSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<SnakeManager>();

        if(!gameManager)
            Debug.LogError("NO GAME MANAGER!!");

        pointsText.text = gameManager.GetCurrentScore().ToString();

        previousSceneIndex = gameManager.GetPreviousSceneIndex();
    }

    public void PlayAgain()
    {
        FindObjectOfType<SceneLoader>().LoadScene(gameManager.GetPreviousSceneIndex());
    }

    
}
