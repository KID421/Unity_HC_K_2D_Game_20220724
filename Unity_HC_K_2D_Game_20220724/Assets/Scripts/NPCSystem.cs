using UnityEngine;

namespace KID
{
    /// <summary>
    /// NPC �t��
    /// </summary>
    public class NPCSystem : MonoBehaviour
    {
        /// <summary>
        /// �e������
        /// </summary>
        private CanvasGroup groupTip;

        private string namePlayer = "�M�h";

        private void Awake()
        {
            groupTip = GameObject.Find("�e������").GetComponent<CanvasGroup>();
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
