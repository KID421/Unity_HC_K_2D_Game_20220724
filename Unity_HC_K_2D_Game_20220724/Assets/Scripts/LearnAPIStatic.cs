using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲ� API �R�A���Ϊk
    /// </summary>
    public class LearnAPIStatic : MonoBehaviour
    {
        private Vector3 v3A = new Vector3(1, 1, 1);
        private Vector3 v3B = new Vector3(22, 22, 22);

        private void Start()
        {
            #region �{���R�A�ݩ�
            // �R�A�ݩ�
            // 1. ���o Get
            // �y�k�G���O�W��.�R�A�ݩ�
            print($"<color=red>{Random.value}</color>");

            // 2. �]�w Set (Read Only ����]�w)
            // �y�k�G���O�W��.�R�A�ݩ� ���w �ȡF
            // Random.value = 0.3f; ��Ū�ݩʤ���]�w
            Cursor.visible = false;
            #endregion

            // �m�� ���o�R�A�ݩ� 1 ~ 2
            print($"��v���ƶq { Camera.allCamerasCount }");
            print($"���x { Application.platform }");

            // �m�� �]�w�R�A�ݩ� 1 ~ 2
            Physics.sleepThreshold = 10;
            Time.timeScale = 0.5f;

            // �m�� �I�s�R�A��k 1�A2�A4
            print(Mathf.Round(2.5f));
            print(Mathf.Floor(2.5f));
            print(Mathf.Ceil(2.5f));

            print($"A B �I�Z�� { Vector3.Distance(v3A, v3B) }");

            Application.OpenURL("https://unity.com/");
        }

        private void Update()
        {
            #region �{���R�A��k
            // �R�A��k
            // 3. �ϥΤ�k
            // �y�k�G���O�W��.�R�A��k(�����޼�)
            // print(Random.Range(0, 3));
            #endregion

            // �m�� ���o�R�A�ݩ� 3 ~ 4
            // print($"�O�_���U���N�� { Input.anyKeyDown }");
            // print($"�C���g�L�ɶ� {Time.time }");
            
            // �m�� �I�s�R�A��k 3
            print($"�O�_���U�ť��� {Input.GetKeyDown(KeyCode.Space) }");
        }
    }
}
