using System;
public class m
{
	static void Main()
	{
		string all="89plokm0ijnuhb7ygv6tfc5rdx4esz3waq12QWERTYUIOPLAKSJDHFGMZNXBCV[]{};:/?.,<>!@#$%^&*()-=_+", mypass="";
		var rnd = new Random();
		int pwlen=8;
		for (int i=1; i<=pwlen; i++)
			mypass += all[rnd.Next(all.Length)];
		Console.WriteLine("Your password is:");
		Console.Write(mypass);
	}
}