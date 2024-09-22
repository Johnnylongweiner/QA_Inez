using TMPro;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
    private int Age = 30;
    private int PhysicalDamage = 60;
    private int Armor = 100;
    private int MagicDamage = 45;
    private int MagicResistance = 15;
    private float speed = 60.0f;

    public void ButtonPressed()
    {

        m_Text.text = $"Name : Andrei \n age ; {Age} \n Race : Mexican \n Physical Damage: {PhysicalDamage} \n Armor: {Armor} \n Magic Damage {MagicDamage} \n Magic Resistance: {MagicResistance} \n Speed {speed}";
    }
}
