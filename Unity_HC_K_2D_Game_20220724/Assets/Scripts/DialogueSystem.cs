using UnityEngine;
using TMPro;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 對話系統
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        /// <summary>
        /// 畫布對話
        /// </summary>
        private CanvasGroup groupDialogue;
        /// <summary>
        /// NPC 名稱
        /// </summary>
        private TextMeshProUGUI textNPC;
        /// <summary>
        /// 對話內容
        /// </summary>
        private TextMeshProUGUI textContent;

        [SerializeField, Header("對話框三角形")]
        private GameObject goTriangle;

        private void Awake()
        {
            groupDialogue = GameObject.Find("畫布對話").GetComponent<CanvasGroup>();
            textNPC = GameObject.Find("NPC 名稱").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話內容").GetComponent<TextMeshProUGUI>();
        }

        /// <summary>
        /// 開始對話
        /// </summary>
        public void StartDialogue()
        {
            StartCoroutine(FadeGroup());
        }

        /// <summary>
        /// 淡入淡出群組
        /// </summary>
        /// <param name="fadeIn">是否淡入</param>
        private IEnumerator FadeGroup(bool fadeIn = true)
        {
            groupDialogue.alpha = fadeIn ? 0 : 1;

            float increase = fadeIn ? 0.1f : -0.1f;

            for (int i = 0; i < 10; i++)
            {
                groupDialogue.alpha += increase;
                yield return new WaitForSeconds(0.05f);
            }
        }
    }
}
