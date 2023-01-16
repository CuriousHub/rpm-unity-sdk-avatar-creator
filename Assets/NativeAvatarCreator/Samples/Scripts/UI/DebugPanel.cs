using UnityEngine;
using UnityEngine.UI;

namespace AvatarCreatorExample
{
    public class DebugPanel : MonoBehaviour
    {
        [SerializeField] private Text debugText;

        private static Text text;

        private void Awake()
        {
            text = debugText;
        }

        public static void AddLogWithDuration(string log, float time)
        {
            text.text += $"{log} <b>[{time:F2}s]</b>  \n";
        }
    }
}
