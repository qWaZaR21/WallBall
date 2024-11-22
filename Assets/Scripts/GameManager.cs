using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshPro levelNumberText;

    void Start()
    {
        int buildIndex = SceneManager.GetActiveScene().buildIndex;
        levelNumberText.text = buildIndex.ToString();
    }

    void Update()
    {
        
    }
}
