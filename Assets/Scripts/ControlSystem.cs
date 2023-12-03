
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;      //單行註解
namespace noctis
{
    /// <summary>
    /// 讓玩家控制原住民左右開跑
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        /* 練習的區域
        // 欄位 Field
        // 儲存遊戲內的資料

        //  常用資料類型
        //  整  數 int
        // 浮點數 float
        // 字  串 string
        // 布林值 bool

        // 欄位語法
        // 修飾詞 欄位資料類型 欄位名稱 指定 值;
        // 公開:顯示(但危險)public
        // 私人 預設:不顯示 privare
        public int lv=1;
        public float cd =3.5f;
        public string skillNname = "冰河紀元";
        public bool isDead = false;

        //喚醒事件:遊戲開始後跑一次
        private void Awake()
        {
            print("<color=red>5201314</color>");
        }
        //開始事件
        private void Start()
        {
            print("<color=blue>嗨今天過得好嗎</color>");
        }
        //更新事件:盡量60FPS
        private void Update()
        {
            print("更新事件");
        }
     */
        [Header("移速"), Range(0, 50)]
        public float moveSpeed = 2.5f;
        [Header("左邊界"), Tooltip("這是角色最左的地方")]
        public float limitleft = -4.3f;
        [Header("右邊界")]
        public float limitright = 4.3f;

        //喚醒事件:遊戲開始時執行一次
       /*rivate void Awake()
            
        {
            print(777);
            print("嗨今天過得好嗎");
            print(moveSpeed);
            print("<color=yellow>黃色的字</color>");
            print("<color=#69f>左邊邊界:limitleft</color>");
            print($"<color=#69f>左邊邊界:{limitleft}</color>");
        }*/

        //更新事件:約60FPS
        //可以偵測玩家的輸入行為
        private void Update()
        {
            M();
        }

        private void M()
        {
            // h = 玩家輸入水平按鍵
            float h = Input.GetAxis("Horizontal");
            //print($"<color=#96f>水平值:{h}</color>");

            transform.Translate(h * Time.deltaTime * moveSpeed, 0, 0);

            //角色的座標
            //print(transform.position);

            // 點 = 角色的座標
            Vector3 point = transform.position;

            //點.x = 數學的夾數(點.x，左邊界，右邊界)
            point.x = Mathf.Clamp(point.x, limitleft, limitright);

            //角色的座標 = 點
            transform.position = point;
        }
    }



}
