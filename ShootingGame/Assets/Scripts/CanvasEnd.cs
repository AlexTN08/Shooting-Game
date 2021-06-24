using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasEnd : MonoBehaviour
{
    public void LoadSpecificScene()
    {
        SceneManager.LoadScene(2);
    }
}
