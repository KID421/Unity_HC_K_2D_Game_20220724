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
    }
}
