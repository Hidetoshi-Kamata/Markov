using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Markov
{
	class Markov
	{
		private List<List<String>> tables;
		private Random rnd = new Random();
		private int kai = 3;

		public Markov(int n)
		{
			tables = new List<List<String>>();
			kai = n;
		}

		/// <summary>
		/// 分かち書きされた文字列から連鎖用テーブルを作成する
		/// （学習）
		/// </summary>
		/// <param name="wakachi"></param>
		public void AddTable(String wakachi)
		{
			var list = wakachi.Split(' ').ToList();

			if (list.Count() < kai) return;		// 生成結果文字列

			list.Insert(0, "__BEGIN__");
			list.Add("__END__");

			foreach (var i in Enumerable.Range(0, list.Count() - kai + 1))
			{
				var entities = new List<String>();
				foreach (var j in Enumerable.Range(0, kai))
				{
					entities.Add(list[i + j]);
				}
				tables.Add(entities);
			}
		}

		/// <summary>
		/// 文字列を生成する
		/// </summary>
		/// <returns></returns>
		public String Generate()
		{
			String result = String.Empty;
			String target;
			var startPoints = (from t in tables where t[0] == "__BEGIN__" select t).ToList();
			var start = startPoints[rnd.Next(0, startPoints.Count())];
			target = start[1]; // __BEGIN__ の次の文字がマルコフ連鎖対象形態素
			do
			{
				var nextPoints = (from t in tables where t[0] == target select t).ToList();
				List<String> next;
				if (nextPoints.Count != 0)
				{
					next = nextPoints[rnd.Next(0, nextPoints.Count())];
					target = next[kai - 1];	// 最終形態素がマルコフ連鎖対象形態素
				}
				else
				{
					// 次がないので終了
					result += target;
					break;
				}
				foreach (var i in Enumerable.Range(0, kai - 1))
				{
					result += next[i];
				}
				if (target == "__END__") break;
			} while (true);
			return result;
		}
	}
}
