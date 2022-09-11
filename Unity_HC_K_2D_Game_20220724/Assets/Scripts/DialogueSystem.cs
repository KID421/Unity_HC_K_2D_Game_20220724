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
        #region ���
        [SerializeField, Header("��ܮؤT����")]
        private GameObject goTriangle;
        [SerializeField, Header("��ܥ��r�ĪG���j"), Range(0, 0.5f)]
        private float intervalTypeEffect = 0.05f;
        [SerializeField, Header("��ܫ���")]
        private KeyCode keyDialogue = KeyCode.E;

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
        /// <summary>
        /// ��e NPC ���
        /// </summary>
        private DataNPC dataNPC;

        public delegate void delegateDialogueFinish();
        private delegateDialogueFinish dialogueFinish;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            groupDialogue = GameObject.Find("�e�����").GetComponent<CanvasGroup>();
            textNPC = GameObject.Find("NPC �W��").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("��ܤ��e").GetComponent<TextMeshProUGUI>();
        }
        #endregion

        #region ���}��k
        /// <summary>
        /// �}�l���
        /// </summary>
        /// <param name="_dataNPC">NPC ���</param>
        public IEnumerator StartDialogue(DataNPC _dataNPC, delegateDialogueFinish _finish)
        {
            dialogueFinish = _finish;

            dataNPC = _dataNPC;                             // �N NPC �ǹL�Ӫ�����x�s
            textNPC.text = dataNPC.nameNPC;                 // ��s NPC �W��
            textContent.text = "";                          // �M�� NPC ��ܤ��e

            yield return StartCoroutine(FadeGroup());       // ���� �Ө�P�{��

            StartCoroutine(TypeEffect());
        }
        #endregion

        #region �p�H��k
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

        /// <summary>
        /// ���r�ĪG
        /// </summary>
        private IEnumerator TypeEffect()
        {
            for (int j = 0; j < dataNPC.content.Length; j++)                        // �M�� �C�@�q���
            {
                string content = dataNPC.content[j];                                // ���o �C�@�� ��ܸ��
                goTriangle.SetActive(false);                                        // ���� �T����
                textContent.text = "";                                              // �M�Ź�ܤ��e

                for (int i = 0; i < content.Length; i++)                            // �j��M����ܨC�@�Ӧr
                {
                    textContent.text += content[i];                                 // ��ܤ��e �֥[ ��ܨC�@�Ӧr
                    yield return new WaitForSeconds(intervalTypeEffect);            // ����
                }

                goTriangle.SetActive(true);                                         // ��� �T����

                while (!Input.GetKeyDown(keyDialogue))                              // �p�G �S�����U��ܫ��� �N���򵥫�
                {
                    yield return null;                                              // null ���� �@�Ӽv�檺�ɶ��G������J
                }
            }

            StartCoroutine(FadeGroup(false));
            
            dialogueFinish();
        }
        #endregion
    }
}
