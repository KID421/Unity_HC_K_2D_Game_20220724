using UnityEngine;

namespace KID
{
    /// <summary>
    /// 音效管理器
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;

        private AudioSource aud;

        private void Awake()
        {
            instance = this;
            aud = GetComponent<AudioSource>();
        }
    }
}
