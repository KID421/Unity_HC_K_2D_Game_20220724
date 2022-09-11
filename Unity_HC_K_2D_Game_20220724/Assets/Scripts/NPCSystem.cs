using UnityEngine;
using System.Collections;
using Cinemachine;

namespace KID
{
    /// <summary>
    /// NPC �t��
    /// </summary>
    public class NPCSystem : MonoBehaviour
    {
        #region ���}���
        [SerializeField, Header("�}�l��ܫ���")]
        private KeyCode keyStartDialogue = KeyCode.E;
        [SerializeField, Header("NPC ���")]
        private DataNPC dataNPC;
        #endregion

        #region �n�������
        private MoveSystem moveSystem;
        private JumpSystem jumpSystem;
        #endregion

        #region �p�H���
        /// <summary>
        /// �e������
        /// </summary>
        private CanvasGroup groupTip;
        private string namePlayer = "�M�h";
        private bool isInArea;
        /// <summary>
        /// �O�_��ܤ�
        /// </summary>
        private bool isDialogue;
        private DialogueSystem dialogueSystem;
        #endregion

        // Ctrl + R R �靈�ϥΨ�ӵ���ƦW�٭��s�R�W
        /// <summary>
        /// NPC CM ��v��
        /// </summary>
        private CinemachineVirtualCamera cvcCM;

        private void Awake()
        {
            groupTip = GameObject.Find("�e������").GetComponent<CanvasGroup>();
            cvcCM = GameObject.Find(dataNPC.nameCamera).GetComponent<CinemachineVirtualCamera>();

            moveSystem = FindObjectOfType<MoveSystem>();
            jumpSystem = FindObjectOfType<JumpSystem>();
            dialogueSystem = FindObjectOfType<DialogueSystem>();
        }

        // 60 FPS
        private void Update()
        {
            InputAndStartDialogue();
        }

        // 50 FPS
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(namePlayer))
            {
                isInArea = true;
                StopAllCoroutines();
                StartCoroutine(FadeGroup());
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.name.Contains(namePlayer))
            {
                isInArea = false;
                StopAllCoroutines();
                StartCoroutine(FadeGroup(false));
            }
        }

        /// <summary>
        /// �H�J�H�X�s��
        /// </summary>
        /// <param name="fadeIn">�O�_�H�J</param>
        private IEnumerator FadeGroup(bool fadeIn = true)
        {
            groupTip.alpha = fadeIn ? 0 : 1;

            float increase = fadeIn ? 0.1f : -0.1f;

            for (int i = 0; i < 10; i++)
            {
                groupTip.alpha += increase;
                yield return new WaitForSeconds(0.05f);
            }
        }

        /// <summary>
        /// ��J���䰻���åB�}�l���
        /// </summary>
        private void InputAndStartDialogue()
        {
            if (isDialogue) return;

            if (isInArea && Input.GetKeyDown(keyStartDialogue))
            {
                isDialogue = true;

                moveSystem.enabled = false;
                jumpSystem.enabled = false;
                cvcCM.Priority = 11;

                StopAllCoroutines();
                StartCoroutine(FadeGroup(false));

                StartCoroutine(dialogueSystem.StartDialogue(dataNPC));
            }
        }

        /// <summary>
        /// ��ܵ�����B�z
        /// </summary>
        private void DialogueFinish()
        {
            isDialogue = false;

            moveSystem.enabled = true;
            jumpSystem.enabled = true;
            cvcCM.Priority = 9;
        }
    }
}
