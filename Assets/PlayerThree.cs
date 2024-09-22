using TMPro;
using UnityEngine;

public class PlayerThree : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
    private int Age = 1000;
    private int PhysicalDamage = 100;
    private int Armor = 100;
    private int MagicDamage = 100;
    private int MagicResistance = 100;
    private float speed = 100.0f;

    public void ButtonPressed()
    {

        m_Text.text = $"Name : Adrian \n age ; {Age} \n Race : African \n Physical Damage: {PhysicalDamage} \n Armor: {Armor} \n Magic Damage {MagicDamage} \n Magic Resistance: {MagicResistance} \n Speed {speed}";
    }
}
