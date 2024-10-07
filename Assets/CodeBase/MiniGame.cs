using DTT.MinigameMemory;
using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase
{
    public class MiniGame : MonoBehaviour
    {
        [SerializeField] private MemoryGameManager memoryGameManager;
        [SerializeField] private MemoryGameSettings settings;

        private void OnEnable() => 
            memoryGameManager.Finish += BackToGame;

        private void OnDisable() => 
            memoryGameManager.Finish -= BackToGame;

        private void Start() => 
            memoryGameManager.StartGame(settings);

        private void BackToGame(MemoryGameResults obj)
        {
            Engine.GetService<ScriptPlayer>().PreloadAndPlayAsync("YardAfterGame");
        }
    }
}
