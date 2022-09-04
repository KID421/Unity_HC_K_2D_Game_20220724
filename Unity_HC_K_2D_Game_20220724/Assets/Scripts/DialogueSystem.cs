using UnityEngine;
using TMPro;
using System.Collections;

namespace KID
{
    /// <summary>
    /// ��ܨt��
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        /// <summary>
        /// �e�����
        /// </summary>
        private CanvasGroup groupDialogue;
        /// <summary>
        /// NPC �W��
        /// </summary>
        private TextMeshProUGUI textNPC;
        /// <summary>
        /// ��ܤ��e
        /// </summary>
        private TextMeshProUGUI textContent;

        [SerializeField, Header("��ܮؤT����")]
        private GameObject goTriangle;

        private void Awake()
        {
            groupDialogue = GameObject.Find("�e�����").GetComponent<CanvasGroup>();
            textNPC = GameObject.Find("NPC �W��").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("��ܤ��e").GetComponent<TextMeshProUGUI>();
        }

        /// <summary>
        /// �}�l���
        /// </summary>
        public void StartDialogue()
        {
            StartCoroutine(FadeGroup());
        }

        /// <summary>
        /// �H�J�H�X�s��
        /// </summary>
        /// <param name="fadeIn">�O�_�H�J</param>
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
