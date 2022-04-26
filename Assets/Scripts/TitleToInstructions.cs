using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleToInstructions : MonoBehaviour
{
    public Button InstButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = InstButton.GetComponent<Button>();
        btn.onClick.AddListener(ToInstructions);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ToInstructions()
    {
        SceneManager.LoadScene(1);
    }
}
