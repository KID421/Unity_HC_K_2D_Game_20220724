using UnityEngine;
using System.Collections;   // 1. �ޥΨt�ζ��X

namespace KID
{
    /// <summary>
    /// �ǲߨ�P�{��
    /// </summary>
    public class LearnCoroutine : MonoBehaviour
    {
        private void Awake()
        {
            StartCoroutine(Test());
        }

        private IEnumerator Test()
        {
            print("�Ĥ@�q�{��");

            yield return new WaitForSeconds(3);

            print("�T������ĤG�q");

            yield return new WaitForSeconds(4);

            print("�|������ĤT�q");
        }
    }
}
