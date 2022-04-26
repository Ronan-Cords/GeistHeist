using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstToMenu : MonoBehaviour
{
    public Button backButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = backButton.GetComponent<Button>();
        btn.onClick.AddListener(BackToMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
