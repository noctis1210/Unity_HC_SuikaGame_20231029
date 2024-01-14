using TMPro;
using UnityEngine;

namespace noctis
{
    ///<summary>
    ///分數管理
    /// </summary>
    [DefaultExecutionOrder(0)]
    public class ScoreManager : MonoBehaviour
    {
        [Header("分數")]
        public TextMeshProUGUI textScore;
        [Header("所有史萊姆的分數")]
        public int[] slimeScores = { 10, 20, 30, 40, 50, 60, 70, 80 };
        
        private int totalScore;

        public static ScoreManager instance;

        // 分數 0 ~ 100 生成 0 1 2
        // 分數 100 ~ 500 生成 0 1 2 3 4
        // 分數 500 ~ 1000 生成 0 1 2 3 4 5 6
        public int maxSlimeIndex = 2;
        private void Awake()
        {
            instance = this;
        }

        ///<summary>
        ///加分數方法
        /// </summary>
        ///<param name="_index">要加編號幾的史萊姆分數</param>
        public void AddScore(int _index)
        {
            //拿出對應編號的史萊姆分數
            int score = slimeScores[_index];
            //累加總分
            totalScore += score;
            //更新分數文字介面 = 總分.轉為文字();
            textScore.text = totalScore.ToString();

            ChangeMaxSlimeIndex();
        }
        ///<summary>
        ///變更最大史萊姆編號
        /// </summary>
        private void ChangeMaxSlimeIndex()
         {
                //如果 總分 >= 500 最大編號 6
                if (totalScore >= 500) maxSlimeIndex = 6;
                //如果 總分 >= 100 最大編號 4
                else if (totalScore >= 100) maxSlimeIndex = 4;

                print($"<color=#f99>最大史萊姆編號:{maxSlimeIndex}</color>");
         }
        }
    }
}