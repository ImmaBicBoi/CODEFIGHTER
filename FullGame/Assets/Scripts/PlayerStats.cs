using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	public static int Money;
	public static int startMoney = 400;

	public static int Lives;
	public static int startLives = 20;

	void Start ()
	{
		Money = startMoney;
		Lives = startLives;
	}

}
