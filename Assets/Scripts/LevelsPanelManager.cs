using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsPanelManager : MonoBehaviour
{
    [SerializeField] GameObject buttonPrefab;
    [SerializeField] Transform canvasTransform;

    int sceneCount;

    void Start()
    {
        sceneCount = SceneManager.sceneCountInBuildSettings - 1;
        Debug.Log("sceneCount: " + sceneCount);

        for (int i = 0; i < sceneCount; i++)
        {
            GameObject newButton = Instantiate(buttonPrefab, canvasTransform);
            newButton.name = "LevelButton " + (i + 1);
            TMP_Text buttonText = newButton.GetComponentInChildren<TMP_Text>();
            buttonText.text = (i + 1).ToString();

            Button buttonComponent = newButton.GetComponent<Button>();
            buttonComponent.onClick.AddListener(() => OnButtonClick(newButton));
        }
    }
    void OnButtonClick(GameObject button)
    {
        TMP_Text buttonText = button.GetComponentInChildren<TMP_Text>();
        SceneManager.LoadScene(int.Parse(buttonText.text));
    }
}