using UnityEngine;

namespace KID
{
    /// <summary>
    /// �j��Gfor
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private void Awake()
        {
            for (int x = 0; x < 100; x++)
            {
                print("�j����榸�ơG" + x);
            }
        }
    }
}
