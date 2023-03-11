using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    [SerializeField] GameObject charSelectScreen;
    [SerializeField] GameObject player;
    [SerializeField] GameObject CharOne, CharTwo, CharThree;
    [SerializeField] Animator COne, CTwo, CThree;
    private bool paused = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
            Pause();
            charSelectScreen.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && paused == true)
        {
            charSelectScreen.SetActive(false);
            Unpause();
        }
    }

    public void CharacterOneSelect()
    {
        CharOne.SetActive(true);
        CharTwo.SetActive(false);
        CharThree.SetActive(false);
        player.GetComponent<PlayerMovement_2D>().animator = COne;
    }
    public void CharacterTwoSelect()
    {
        CharOne.SetActive(false);
        CharTwo.SetActive(true);
        CharThree.SetActive(false);
        player.GetComponent<PlayerMovement_2D>().animator = CTwo;
    }
    public void CharacterThreeSelect()
    {
        CharOne.SetActive(false);
        CharTwo.SetActive(false);
        CharThree.SetActive(true);
        player.GetComponent<PlayerMovement_2D>().animator = CThree;
    }

    void Pause()
    {
        paused = true;
        Time.timeScale = 0;
    }

    void Unpause()
    {
        paused = false;
        Time.timeScale = 1;
    }
}
