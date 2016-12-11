using System;
public class PasswordGenerator
{
	static void Main()
	{
		string all="89plokm0ijnuhb7ygv6tfc5rdx4esz3waq12QWERTYUIOPLAKSJDHFGMZNXBCV[]{};:/?.,<>!@#$%^&*()-=_+", mypass="";
		var rnd = new Random();
		int pw_len=8;
		for (int i=1; i<=pw_len; i++)
			mypass += all[rnd.Next(all.Length)];
		Console.WriteLine("Your password is:");
		Console.Write(mypass);
	}
}
