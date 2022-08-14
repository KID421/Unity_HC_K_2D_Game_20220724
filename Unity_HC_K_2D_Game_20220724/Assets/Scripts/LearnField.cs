using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲ���� Field�A�O�s�C���������
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        #region ����¦�y�k
        // ���y�k�G
        // ������� ���ۭq�W�١F
        // ������� ���ۭq�W�� ���w �ȡF

        // ���w�Ÿ� = �N�k�����������

        // �� �׹��� ������� ���ۭq�W�� ���w �ȡF
        int number;

        // �T�����
        // CC ��
        // ���q
        // �~�P
        // �O�_���ѵ�

        // �׹����w�]���p�H
        // �p�H private ����ܤ����\�~���s��
        // ���} public ��ܤ��\�~���s��
        public int cc = 1500;
        public float weight = 3.5f;
        public string brand = "�S����";
        public bool hasSkyWindow = true;

        // ����ݩ� [�ݩʦW��(��)]
        // 1. ���� Tooltip(�r��)
        // 2. ���D Header(�r��)
        // 3. �d�� Range(�ƭȫ��A�A�ƭȫ��A) - �ȭ��ƭ����� float �� int
        // 4. �ǦC�� SerializedField �N�p�H������
        [Tooltip("�o�O���a���ƶq.....")]
        public int count;
        [Header("�����O")]
        public float attack = 10.5f;
        [Range(50, 1500)]
        public int hp = 100;
        [Header("�Z���W��")]
        [Tooltip("�o�O���a���Z��")]
        public string weapon = "�p�M";
        [Header("�O�_���`"), Tooltip("���a�O�_���`")]
        public bool isDead = false;

        // C# OOP ����ɦV�{���]�p
        // �T�j�S�ʡG�~�ӡB�ʸˡB�h��
        // �ʸˡG�N�����O�����e�ʳ��b���O���ȴ��ѥ~���ݭn�����f
        
        public string password = "123456789";   // �����S���ʸ˪����n�ܽd

        /// <summary>
        /// �ǦC�����A�ʸ˦���Ʀ���ܦb�ݩʭ��O
        /// </summary>
        [SerializeField]
        private int speed = 10;
        #endregion

        #region Unity ���������
        // �x�s����
        public GameObject goCamera;

        // �C��P�y��
        public Color color;
        public Color colorRed = Color.red;
        public Color colorYellow = Color.yellow;
        public Color colorCustom1 = new Color(0.5f, 0.5f, 0);
        public Color colorCustomAlpha = new Color(0, 0, 1, 0.5f);

        public Vector2 v2;
        public Vector2 v2Right = Vector2.right; // 1, 0
        public Vector2 v2Up = Vector2.up;       // 0, 1
        public Vector2 v2Custom = new Vector2(9, 1);

        public Vector3 v3Custom = new Vector3(9, 10, 11);
        public Vector3 v3Right = Vector3.right;

        public Vector4 v4Custom = new Vector4(1, 2, 3, 4);

        // �h��P�C�|
        public LayerMask layer;

        public LightType lightType;
        public LightType lightTypeArea = LightType.Area;
        public KeyCode keyA;
        public KeyCode keyJump = KeyCode.Space;

        // ����
        public Transform tra;
        public SpriteRenderer spr;
        public Animator ani;
        #endregion
    }
}
