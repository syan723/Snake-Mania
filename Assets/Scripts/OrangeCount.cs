using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrangeCount : MonoBehaviour
{

    SnakeManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<SnakeManager>();
        if(!gameManager)
        {
            Debug.Log("NO GAME MANAGER FOUND");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Display the total number of points the player has
        gameObject.GetComponent<TextMeshProUGUI>().text = gameManager.GetPoints().ToString();
    }
}
