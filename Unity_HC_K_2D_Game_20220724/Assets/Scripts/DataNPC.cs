using UnityEngine;

namespace KID
{
    /// <summary>
    /// NPC ��ơGNPC �W�ٻP��ܤ��e
    /// </summary>
    [CreateAssetMenu(menuName = "KID/NPC Data", fileName = "NPC Data")]
    public class DataNPC : ScriptableObject
    {
        [Header("NPC �W��")]
        public string nameNPC;
        [Header("��ܤ��e"), TextArea(3, 10)]
        public string[] content;
    }
}
