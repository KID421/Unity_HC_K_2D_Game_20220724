using UnityEngine;
using TMPro;

namespace KID
{
    /// <summary>
    /// 任務管理
    /// </summary>
    public class MissionManager : MonoBehaviour
    {
        public static MissionManager instance;

        [SerializeField, Header("任務需求數量"), Range(1, 100)]
        private int countMax = 30;
        [SerializeField, Header("要更新的 NPC")]
        private NPCSystem npcTarget;
        [SerializeField, Header("要更新的對話資料")]
        private DataNPC dataNPC;

        private int countCurrent;
        private TextMeshProUGUI textMission;

        private void Awake()
        {
            instance = this;

            textMission = GameObject.Find("任務數量文字").GetComponent<TextMeshProUGUI>();

            UpdateCountAndUI();
        }

        /// <summary>
        /// 更新數量與介面
        /// </summary>
        public void UpdateCountAndUI(int increase = 0)
        {
            countCurrent += increase;
            textMission.text = $"南瓜數量：{countCurrent} / {countMax}";

            if (countCurrent >= countMax) MissionComplete();
        }

        private void MissionComplete()
        {
            npcTarget.dataNPC = dataNPC;
        }
    }
}
