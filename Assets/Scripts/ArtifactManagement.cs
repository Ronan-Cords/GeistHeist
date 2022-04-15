using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ArtifactManagement  
{
    public static int ArtifactsCollected;
    public static GameObject ToWinGameEndObject;
    // Start is called before the first frame update


    public static void ArtifactCounter()
    {   
        if (ArtifactsCollected >= 4)
        {
            ToWinGameEndObject.SetActive(true); 
        }
    }
}
