using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	//得点を表示するテキスト
	private GameObject ScoreControllerText;
	//初期スコア
	private int score = 0;
	//各オブジェクトごとの得点
	private int smallstarscore =10;
	private int largestarscore =20;
	private int smallcloudscore =15;
	private int largecloudscore =25;

	// Use this for initialization
	void Start () {
		//シーン中のScoreControllerTextオブジェクトを取得
		this.ScoreControllerText = GameObject.Find("ScoreController");
	}

	// Update is called once per frame
	void Update () {
		// ここでは何もしない
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "SmallStarTag")
		{
			//小さい星のスコアを加算
			this.score += smallstarscore;
		}
		else if(other.gameObject.tag == "LargeStarTag")
		{                
			//大きい星のスコアを加算
			this.score += largestarscore;
		}
		else if(other.gameObject.tag == "SmallCloudTag")
		{                    
			//小さい雲のスコアを加算
			this.score += smallcloudscore;
		}
		else if(other.gameObject.tag == "LargeCloudTag")
		{
			//大きい雲のスコアを加算
			this.score += largecloudscore;
		}
		//ScoreControllerTextに点数を表示
		this.ScoreControllerText.GetComponent<Text> ().text = score.ToString()+ "点" ;
	}
}