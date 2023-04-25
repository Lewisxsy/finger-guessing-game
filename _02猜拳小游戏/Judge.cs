namespace _02猜拳小游戏
{
	internal class Judge
	{
		public string IsUserWin(int user, int computer)
		{
			if (user - computer == 0)
			{
				return "平局";
			}
			if (user - computer == -1 || user - computer == 2)
			{
				return "用户赢了";
			}
			return "用户输了";
		}
	}
}
