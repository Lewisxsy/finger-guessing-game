namespace _02猜拳小游戏
{
	internal class UserPlayer
	{
		public string FistName { get; set; }

		public int ShowFist(string msg)
		{
			FistName = msg;
			int result = 0;
			switch (msg)
			{
			case "石头":
				result = 1;
				break;
			case "剪刀":
				result = 1;
				break;
			case "布":
				result = 1;
				break;
			}
			return result;
		}
	}
}
