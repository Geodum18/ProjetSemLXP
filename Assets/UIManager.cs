using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{

    public Image hpbar;
    public TextMeshProUGUI hpText;
    private float cooldown=0;
    public float maxCooldown;
    public Image spell;
    public TextMeshProUGUI spellText;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   cooldown+= 1f * Time.deltaTime;

        CooldownBar(cooldown, maxCooldown);
        if (cooldown>=maxCooldown){
            spellText.text ="Spell ready !";
        }
        if ((Input.GetKey(KeyCode.Space))&&(cooldown>=maxCooldown))
        {
          CooldownBar(0, maxCooldown);
          cooldown=0;
        }
    }

    public void ChangeHealthBar(float value, float maxValue)
    {
        hpbar.fillAmount=value/maxValue;
        hpText.text = "Current health" + value + "/" + maxValue;
    }

    public void CooldownBar(float value, float maxValue)
    {
        spell.fillAmount=value/maxValue;
        spellText.text = "Cooldown : " + (10-value).ToString("#.#") + " s.";
    }
}
