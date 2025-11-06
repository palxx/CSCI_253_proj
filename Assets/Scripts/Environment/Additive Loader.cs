using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveLoader : MonoBehaviour
{
    [SerializeField] string[] additiveScenes = {
        "Scenes/Additive/Env_Global",
        "Scenes/Additive/Rooms/Room_A",
        "Scenes/Additive/Rooms/Room_B"
        // add more rooms or feature scenes here
    };

    void Start()
    {
        foreach (var scenePath in additiveScenes)
        {
            SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Additive);
        }
    }
}