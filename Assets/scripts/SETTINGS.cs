using UnityEngine;
using UnityEngine.SceneManagement;

public class SETTINGS : MonoBehaviour
{
    public string scenename;
    public void PlayScene()
    {
        SceneManager.LoadScene(scenename);
    }
}

