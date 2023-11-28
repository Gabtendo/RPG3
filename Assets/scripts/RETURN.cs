using UnityEngine;
using UnityEngine.SceneManagement;

public class RETURN : MonoBehaviour
{
    public string scenename;
    public void PlayScene()
    {
        SceneManager.LoadScene(scenename);
    }
}
