using UnityEngine;

namespace KID
{
    /// <summary>
    /// NPC 系統
    /// </summary>
    public class NPCSystem : MonoBehaviour
    {
        /// <summary>
        /// 畫布提示
        /// </summary>
        private CanvasGroup groupTip;

        private string namePlayer = "騎士";

        private void Awake()
        {
            groupTip = GameObject.Find("畫布提示").GetComponent<CanvasGroup>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(namePlayer))
            {
                groupTip.alpha = 1;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.name.Contains(namePlayer))
            {
                groupTip.alpha = 0;
            }
        }
    }
}
