using UnityEngine;

namespace GameFramework.LevelManagement
{
    public abstract class LevelAsset : ScriptableObject
    {
        public const string MENU_PATH = GameFrameworkConstants.MENU_PATH + "Levels/";

        public abstract LevelAsyncOperation PerformLoad();
        public abstract LevelAsyncOperation PerformUnload();
    }
}