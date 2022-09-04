using UnityEngine;

namespace KID
{
    /// <summary>
    /// °j°é¡Gfor
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private void Awake()
        {
            for (int x = 0; x < 100; x++)
            {
                print("°j°é°õ¦æ¦¸¼Æ¡G" + x);
            }
        }
    }
}
