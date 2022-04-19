using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactManagement : MonoBehaviour  
{
    public int ArtifactsCollected;
    public GameObject ToWinGameEndObject;
    // Start is called before the first frame update


    public void ArtifactCounter()
    {
        ArtifactsCollected++;

        if (ArtifactsCollected >= 4)
        {
            ToWinGameEndObject.SetActive(true); 
        }
    }
}
