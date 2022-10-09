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
        #region 資料
        [SerializeField, Header("對話框三角形")]
        private GameObject goTriangle;
        [SerializeField, Header("對話打字效果間隔"), Range(0, 0.5f)]
        private float intervalTypeEffect = 0.05f;
        [SerializeField, Header("對話按鍵")]
        private KeyCode keyDialogue = KeyCode.E;

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
        /// <summary>
        /// 當前 NPC 資料
        /// </summary>
        private DataNPC dataNPC;

        public delegate void delegateDialogueFinish();
        private delegateDialogueFinish dialogueFinish;
        #endregion

        #region 事件
        private void Awake()
        {
            groupDialogue = GameObject.Find("畫布對話").GetComponent<CanvasGroup>();
            textNPC = GameObject.Find("NPC 名稱").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話內容").GetComponent<TextMeshProUGUI>();
        }
        #endregion

        #region 公開方法
        /// <summary>
        /// 開始對話
        /// </summary>
        /// <param name="_dataNPC">NPC 資料</param>
        public IEnumerator StartDialogue(DataNPC _dataNPC, delegateDialogueFinish _finish)
        {
            dialogueFinish = _finish;

            dataNPC = _dataNPC;                             // 將 NPC 傳過來的資料儲存
            textNPC.text = dataNPC.nameNPC;                 // 更新 NPC 名稱
            textContent.text = "";                          // 清空 NPC 對話內容

            yield return StartCoroutine(FadeGroup());       // 等待 該協同程序

            StartCoroutine(TypeEffect());
        }
        #endregion

        #region 私人方法
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

        /// <summary>
        /// 打字效果
        /// </summary>
        private IEnumerator TypeEffect()
        {
            for (int j = 0; j < dataNPC.content.Length; j++)                        // 遍巡 每一段對話
            {
                string content = dataNPC.content[j];                                // 取得 每一筆 對話資料
                goTriangle.SetActive(false);                                        // 隱藏 三角形
                textContent.text = "";                                              // 清空對話內容

                for (int i = 0; i < content.Length; i++)                            // 迴圈遍巡對話每一個字
                {
                    textContent.text += content[i];                                 // 對話內容 累加 對話每一個字
                    yield return new WaitForSeconds(intervalTypeEffect);            // 等待
                }

                goTriangle.SetActive(true);                                         // 顯示 三角形

                while (!Input.GetKeyDown(keyDialogue))                              // 如果 沒有按下對話按鍵 就持續等待
                {
                    yield return null;                                              // null 等待 一個影格的時間：偵測輸入
                }
            }

            StartCoroutine(FadeGroup(false));
            
            dialogueFinish();
        }
        #endregion
    }
}
