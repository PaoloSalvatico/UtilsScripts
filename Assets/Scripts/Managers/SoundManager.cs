using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : PersistentSingleton<SoundManager>
{
    public AudioSource backgroundMusic;

	protected override void Awake()
	{
		base.Awake();
		backgroundMusic = gameObject.AddComponent<AudioSource>();
	}

	public void PlayMusic(AudioClip clip)
	{
		backgroundMusic.loop = true;
		backgroundMusic.clip = clip;
		StartCoroutine(PlayMusicFadeIn(0.45f));
		backgroundMusic.Play();
	}
	IEnumerator PlayMusicFadeIn(float maxvolume)
	{
		float iterattions = 0;
		while (iterattions < maxvolume)
		{
			backgroundMusic.volume = iterattions;
			iterattions += 0.005f;
			yield return new WaitForSecondsRealtime(0.001f);
		}
	}
	IEnumerator PlayMusicFadeOut(float maxvolume)
	{
		float iterattions = maxvolume;
		while (iterattions <= 0)
		{
			backgroundMusic.volume = iterattions;
			iterattions -= 0.01f;
			yield return new WaitForSecondsRealtime(0.001f);
		}
	}

	public void PlaySound2DLenght(AudioClip clip, float volume, float AudioLenght)
	{
		var sourceAudio2D = new GameObject(name = "SFX");
		sourceAudio2D.AddComponent<AudioSource>().clip = clip;
		sourceAudio2D.GetComponent<AudioSource>().Play();
		sourceAudio2D.GetComponent<AudioSource>().volume = volume;

		StartCoroutine(DestroyAudioSource(AudioLenght, sourceAudio2D));
	}

	IEnumerator DestroyAudioSource(float time, GameObject go)
	{
		yield return new WaitForSeconds(time);
		Destroy(go);
	}

	public void GetSoundFromRes(string name)
	{
		var clip = Resources.Load<AudioClip>(name);
		PlaySound2DLenght(clip, 0.5f, clip.length);
	}
}
