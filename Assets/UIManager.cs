using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{

    public Image hpbar;
    public TextMeshProUGUI hpText;
    private float cooldown1;
    public float maxCooldown1;
    public Image spell1;
    public TextMeshProUGUI spellText1;


    private float cooldown2;
    public float maxCooldown2;
    public Image spell2;
    public TextMeshProUGUI spellText2;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   cooldown1-= 1f * Time.deltaTime;

        CooldownBar(cooldown1, maxCooldown1, spell1, spellText1);
        if (cooldown1<=0){
            spellText1.text ="Spell ready !";
        }
        if ((Input.GetKey(KeyCode.Space))&&(cooldown1<=0))
        {
          CooldownBar(cooldown1, maxCooldown1, spell1, spellText1);
          cooldown1=maxCooldown1;
        }

        cooldown2-= 1f * Time.deltaTime;

        CooldownBar(cooldown2, maxCooldown2, spell2, spellText2);
        if (cooldown2<=0){
            spellText2.text ="Spell ready !";
        }
        if ((Input.GetKey(KeyCode.W))&&(cooldown2<=0))
        {
          CooldownBar(cooldown2, maxCooldown2, spell2, spellText2);
          cooldown2=maxCooldown2;
        }
    }

    public void ChangeHealthBar(float value, float maxValue)
    {
        hpbar.fillAmount=value/maxValue;
        hpText.text = "Current health" + value + "/" + maxValue;
    }

    public void CooldownBar(float value, float maxValue, Image spell ,TextMeshProUGUI spellText)
    {
        spell.fillAmount= value/maxValue;
        spellText.text = "Cooldown : " + value.ToString("#.#") + " s.";
    }
}
