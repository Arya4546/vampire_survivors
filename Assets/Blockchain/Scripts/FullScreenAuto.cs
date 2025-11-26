using UnityEngine;

namespace Vampire
{
    public class FullScreenAuto : MonoBehaviour
    {
        void Awake()
        {
            Screen.fullScreen = true;
            // Delay 1 second so WebGL canvas loads properly
        }

        void GoFullScreen()
        {
            Screen.fullScreen = true;
        }
    }

}
