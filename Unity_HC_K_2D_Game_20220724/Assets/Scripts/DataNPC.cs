using UnityEngine;

namespace KID
{
    /// <summary>
    /// NPC 資料：NPC 名稱與對話內容
    /// </summary>
    [CreateAssetMenu(menuName = "KID/NPC Data", fileName = "NPC Data")]
    public class DataNPC : ScriptableObject
    {
        [Header("NPC 名稱")]
        public string nameNPC;
        [Header("對話內容"), TextArea(3, 10)]
        public string[] content;
        [Header("攝影機名稱")]
        public string nameCamera;
    }
}
