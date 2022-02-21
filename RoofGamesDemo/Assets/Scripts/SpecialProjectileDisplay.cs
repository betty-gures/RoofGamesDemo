using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialProjectileDisplay : MonoBehaviour
{

    Text specialProjectileText;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
       specialProjectileText = GetComponent<Text>();
       player = FindObjectOfType<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        specialProjectileText.text= player.GetSpecialProjectile().ToString();
    }
}
