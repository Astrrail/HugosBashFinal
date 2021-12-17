using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    public int CharacterChoice;
    public Transform[] Characters;
    public GameObject SpotLight;
    public Animation HoverSelect;
    public GameObject[] CharacterHover;
    public GameManager GM;
    public GameObject CharcterSelectScreen;
    public GameObject LevelSelect;
    bool OnCharaterSelect;
    // Start is called before the first frame update
    void Start()
    {
        CharacterChoice = 0;
        OnCharaterSelect = true;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (Input.GetKeyDown(KeyCode.LeftArrow) && OnCharaterSelect == true)
        {
            if(CharacterChoice == 0)
            {
                CharacterChoice = 3;
            }
            if(CharacterChoice > 0)
            {
                CharacterChoice--;
            }
            CharacterThings();

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && OnCharaterSelect == true)
        {
            if (CharacterChoice == 3)
            {
                CharacterChoice = 0;
            }
            if (CharacterChoice < 3)
            {
                CharacterChoice++;
            }
            CharacterThings();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SelectScreen();
        }
    }
        void CharacterThings()
    {
        SpotLight.transform.position = Characters[CharacterChoice].position;
        HoverSelect = CharacterHover[CharacterChoice].GetComponent<Animation>();
        HoverSelect.Play();
    }
        void SelectScreen()
    {
        GM.PlayerCharacter = CharacterChoice;
        LevelSelect.SetActive(true);
        CharcterSelectScreen.SetActive(false);
        OnCharaterSelect = false;
    }
}
