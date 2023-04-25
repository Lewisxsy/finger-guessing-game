using System;

namespace _02猜拳小游戏
{
	internal class ComputerPlayer
	{
		public string FistName { get; set; }

		public int ShowFist()
		{
			Random random = new Random();
			int num = random.Next(1, 4);
			switch (num)
			{
			case 1:
				FistName = "石头";
				break;
			case 2:
				FistName = "剪刀";
				break;
			case 3:
				FistName = "布";
				break;
			}
			return num;
		}
	}
}
