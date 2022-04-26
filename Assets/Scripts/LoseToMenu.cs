using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoseToMenu : MonoBehaviour
{
    public Button LoseToMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = LoseToMenuButton.GetComponent<Button>();
        btn.onClick.AddListener(LoseToMenuMethod);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoseToMenuMethod()
    {
        SceneManager.LoadScene(0);
    }
}
