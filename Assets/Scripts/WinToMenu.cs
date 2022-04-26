using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinToMenu : MonoBehaviour
{
    public Button ToMenu;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = ToMenu.GetComponent<Button>();
        btn.onClick.AddListener(GoToMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
