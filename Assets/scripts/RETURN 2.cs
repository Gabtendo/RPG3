using UnityEngine;
using UnityEngine.SceneManagement;

public class RETURN2 : MonoBehaviour
{
    public string scenename;
    public void PlayScene()
    {
        SceneManager.LoadScene(scenename);
    }
}
