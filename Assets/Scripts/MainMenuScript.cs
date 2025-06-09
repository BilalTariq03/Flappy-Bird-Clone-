using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public AudioScript audioManage;

    void Awake()
    {
        audioManage = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioScript>();
    }
    public void OnStartClick()
    {
        audioManage.playSFX(audioManage.click);
        SceneManager.LoadScene("GameScene");
    }    

    public void OnExitClick()
    {
        audioManage.playSFX(audioManage.click);
# if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
