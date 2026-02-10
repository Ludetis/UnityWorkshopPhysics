using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{

    public Button startButton;
    public GameObject loadingText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton.onClick.AddListener(OnStartClicked);
    }

    public void OnStartClicked()
    {
        loadingText.SetActive( true);
        SceneManager.LoadScene("Parcours");
    }

}
