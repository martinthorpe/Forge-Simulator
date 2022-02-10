using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobsMenu : MonoBehaviour
{
    public GameObject shopMenuUI;
    static Jobs jobSlot1;
    static Jobs jobSlot2;
    static Jobs jobSlot3;

    void Start()
    {
        //fills all slots with jobs
        jobSlot1 = new Jobs();
        jobSlot2 = new Jobs();
        jobSlot3 = new Jobs();
    }

    // Update is called once per frame
    void Update()
    {
        if (openJobs.openJob == true && GameManager.gameIsPaused == false)
        {
            if (GameManager.gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        openJobs.openJob = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        shopMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameManager.gameIsPaused = false;
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        shopMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameManager.gameIsPaused = true;
    }

    //fills slot 1 with new job
    public void acceptJobSlot1()
    {
        GameManager.p.changeJob(jobSlot1);
        jobSlot1 = newJob();
    }

    //fills slot 2 with new job
    public void acceptJobSlot2()
    {
        GameManager.p.changeJob(jobSlot2);
        jobSlot2 = newJob();
    }

    //fills slot 3 with new job
    public void acceptJobSlot3()
    {
        GameManager.p.changeJob(jobSlot3);
        jobSlot3 = newJob();
    }

    Jobs newJob()
    {
        return new Jobs();
    }

    public static Jobs returnJobSlot1()
    {
        return jobSlot1;
    }

    public static Jobs returnJobSlot2()
    {
        return jobSlot2;
    }

    public static Jobs returnJobSlot3()
    {
        return jobSlot3;
    }
}
