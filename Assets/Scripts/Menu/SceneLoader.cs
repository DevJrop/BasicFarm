using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class SceneLoader : MonoBehaviour
    {
        [Header("Scene Names (must match Build Settings)")]
        [SerializeField] private string gameSceneName = "SampleScene";
        [SerializeField] private string menuSceneName = "Menu";

        public void LoadGame()
        {
            SceneManager.LoadScene(gameSceneName);
        }
        public void LoadMenu()
        {
            SceneManager.LoadScene(menuSceneName);
        }
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}