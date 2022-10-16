using UnityEngine;
using System.Collections;
using Cinemachine;

namespace KID
{
    /// <summary>
    /// NPC 系統
    /// </summary>
    public class NPCSystem : MonoBehaviour
    {
        #region 公開資料
        [SerializeField, Header("開始對話按鍵")]
        private KeyCode keyStartDialogue = KeyCode.E;
        [SerializeField, Header("NPC 資料")]
        public DataNPC dataNPC;
        #endregion

        #region 要停止的元件
        private MoveSystem moveSystem;
        private JumpSystem jumpSystem;
        #endregion

        #region 私人資料
        /// <summary>
        /// 畫布提示
        /// </summary>
        private CanvasGroup groupTip;
        private string namePlayer = "騎士";
        private bool isInArea;
        /// <summary>
        /// 是否對話中
        /// </summary>
        private bool isDialogue;
        private DialogueSystem dialogueSystem;
        // Ctrl + R R 對有使用到該筆資料名稱重新命名
        /// <summary>
        /// NPC CM 攝影機
        /// </summary>
        private CinemachineVirtualCamera cvcCM;
        #endregion

        #region 事件
        private void Awake()
        {
            groupTip = GameObject.Find("畫布提示").GetComponent<CanvasGroup>();
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
        #endregion

        #region 方法
        /// <summary>
        /// 淡入淡出群組
        /// </summary>
        /// <param name="fadeIn">是否淡入</param>
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
        /// 輸入按鍵偵測並且開始對話
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

                StartCoroutine(dialogueSystem.StartDialogue(dataNPC, DialogueFinish));
            }
        }

        /// <summary>
        /// 對話結束後處理
        /// </summary>
        private void DialogueFinish()
        {
            isDialogue = false;

            moveSystem.enabled = true;
            jumpSystem.enabled = true;
            cvcCM.Priority = 9;
            StartCoroutine(FadeGroup(true));
        }
        #endregion
    }
}
