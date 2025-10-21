using UnityEngine;
using System.Collections.Generic;

// ��˹������ sealed ���ͻ�ͧ�ѹ����׺�ʹ
public class SoundManager : MonoBehaviour
{
   

    [Header("Audio Sources")]
    // Audio Source ����Ѻ�ŧ��Сͺ (Looping)
    public AudioSource musicSource;
    // Audio Source ����Ѻ�Ϳ࿡�����§ (Non-Looping)
    public AudioSource sfxSource;

    [Header("Default Audio Clips")]
    public AudioClip defaultButtonClick;
    public AudioClip defaultBackgroundMusic;

    // 3. Singleton Initialization
 

    // ------------------- Music Controls -------------------

    /// <summary>
    /// ����ŧ��Сͺ����
    /// </summary>
    public void PlayMusic(AudioClip clip)
    {
        if (clip == null || musicSource == null) return;

        musicSource.clip = clip;
        musicSource.Play();
    }

    public void StopMusic()
    {
        if (musicSource != null)
        {
            musicSource.Stop();
        }
    }

    // ------------------- SFX Controls -------------------

    /// <summary>
    /// ����Ϳ࿡�����§Ẻ�������Ǩ� (One-Shot)
    /// </summary>
    public void PlaySFX(AudioClip clip)
    {
        if (clip == null || sfxSource == null) return;

        // �� PlayOneShot �����������������§�Ѻ��͹�ѹ��
        sfxSource.PlayOneShot(clip);
    }

    // ------------------- Volume Controls -------------------

    /// <summary>
    /// ��˹��дѺ���§��ѡ�ͧ�ŧ��Сͺ (0.0 �֧ 1.0)
    /// </summary>
    public void SetMusicVolume(float volume)
    {
        if (musicSource != null)
        {
            musicSource.volume = volume;
        }
    }

    /// <summary>
    /// ��˹��дѺ���§��ѡ�ͧ�Ϳ࿡�����§ (0.0 �֧ 1.0)
    /// </summary>
    public void SetSFXVolume(float volume)
    {
        if (sfxSource != null)
        {
            sfxSource.volume = volume;
        }
    }
}