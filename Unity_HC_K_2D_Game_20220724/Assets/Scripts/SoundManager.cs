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

        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="sound">音效</param>
        /// <param name="rangeVolume">音量範圍</param>
        public void PlaySound(AudioClip sound, Vector2 rangeVolume)
        {
            aud.PlayOneShot(sound, Random.Range(rangeVolume.x, rangeVolume.y));
        }
    }
}
