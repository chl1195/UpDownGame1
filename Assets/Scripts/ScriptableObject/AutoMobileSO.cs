using UnityEngine;

[CreateAssetMenu(fileName = "DefaultAutoMobileSO", menuName = "UpDownController/AutoMobiles/Default", order = 0)]
public class AutoMobileSO : ScriptableObject
{
    [Header("AutoMobile Info")]
    public float size;
    public float speed;
    public Color projectileColor;
}