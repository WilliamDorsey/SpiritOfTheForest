using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCScript : MonoBehaviour
{
    public Text dialogue;
    public int levelNum;
    
    int npcNum = TheOverlord.Level1 + TheOverlord.Level2 + TheOverlord.Level3 + 1;
    private bool inBounds = false;
    private int dialogueNum = 0;

    private void Start()
    {
        dialogue.text = "";
    }

    private void Update()
    {
        if (inBounds && Input.GetKeyDown("e")) //Interacting displays the text for the appropriate NPC.
        {
            dialogueNum += 1;
            WhichNPCAmI();
        }
    }

    private void OnTriggerEnter(Collider other) //When colliding with interact trigger, prompt player to interact
    {
        dialogue.text = "Press 'E' to interact";
        inBounds = true;
    }

    private void OnTriggerExit(Collider other) //Remove text when player leaves NPC
    {
        if (other.tag == "Player")
        dialogue.text = "";
        inBounds = false;
    }

    void WhichNPCAmI() //Directs to correct group of NPC dialogue
    {
        if (npcNum == 1) NPC1();
        else if (npcNum == 2) NPC2();
        else if (npcNum == 3) NPC3();
        else
        {
            dialogue.text = "NPC number not specified.";
        }
    }

    void NPC1() //NPC for level 1
    {
        if (dialogueNum == 1) //Check which line of dialogue to display
        {
            dialogue.text = "Sage! Zephyr has cursed the forest - please be careful. We need to save them - find the 3 ingredients to make a cure."; //Placeholder text
        }
        else if (dialogueNum == 2)
        {
            level();
        }
        else if (dialogueNum == 3)
        {
            dialogue.text = "\"If the animals are cursed how am I still okay?\" I'm thousands of years old like you, Sage. If magic like that could harm me Zephyr would have killed me ages ago."; //Placeholder text
        }
        else
        {
            dialogue.text = "Press 'E' to interact";
            Debug.Log("Reseting dialogue position for NPC 1.");
            dialogueNum = 0;
        }
    }

    void NPC2() //NPC for level 2
    {
        if (dialogueNum == 1) //Check which line of dialogue to display
        {
            dialogue.text = "Well done getting the first ingredient! I can feel Zephyer's anger, but you should have no issue finding the remaining two."; //Placeholder text
        }
        else if (dialogueNum == 2)
        {
            level();
        }
        else if (dialogueNum == 3)
        {
            dialogue.text = "\"How did I get here?\" Why... I teleported! Don't give me that look - I made those portals you used to get here - teleportation is an easy feat after that."; //Placeholder text
        }
        else
        {
            dialogue.text = "Press 'E' to interact";
            Debug.Log("Reseting dialogue position for NPC 2.");
            dialogueNum = 0;
        }
    }

    void NPC3() //NPC for level 3
    {
        if (dialogueNum == 1) //Check which line of dialogue to display
        {
            dialogue.text = "You are so close to getting the last ingredient. I know you can save our friends."; //Placeholder text
        }
        else if (dialogueNum == 2)
        {
            level();
        }
        else if (dialogueNum == 3)
        {
            dialogue.text = "Hurry!"; //Placeholder text
        }
        else
        {
            dialogue.text = "Press 'E' to interact";
            Debug.Log("Reseting dialogue position for NPC 3.");
            dialogueNum = 0;
        }
    }
    void level()
    {
        if (levelNum == 1)
        {
            dialogue.text = "Avoid the ground and the water... high areas of the ground are okay, but if you want to jump down to there you should plant some aorns to create platforms to jump on. The lilypads are safe - and will lead you to an acorn!";
        }
        else if (levelNum == 2)
        {
            dialogue.text = "There used to be a lot of trees here... but they are gone now. Maybe you can find a way across with your powers? Don't mind my size - I can change that at will.";
        }
        else if (levelNum == 3)
        {
            dialogue.text = "Let's go high in the sky! A few snakes are paralyzed up there, but they shouldn't hurt you if you don't mess with them.";
        }
        else
        {
            dialogue.text = "I'm not really sure what to say...";
        }
    }
}
