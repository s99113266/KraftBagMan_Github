using UnityEngine;
[CreateAssetMenu(fileName = "玩家資料", menuName = "CHERRY/PLAY 素質設定")]
public class PlayData : ScriptableObject
{
    [Header("受攻擊次數"), Range(3, 15)]
    public int Hp;
    public int MaxHp;

    [Header("移動速度"), Range(10, 5000)]
    public float Speed;

    [Header("跳躍高度"), Range(10, 5000)]
    public float JumpHeight;
}
