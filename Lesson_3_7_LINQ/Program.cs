using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_3_7_LINQ
{
	class Program
	{
		static void Main(string[] args)
		{
			//LINQ 
			//LINQ to Object
			//LINQ to Entities
			//LINQ to Sql => MS SQL Server
			//LINQ to XML 
			//LINQ to DataSet 
			//Parallel LINQ 

			//int[] a = { 1, 5, 78, 3, 15, 1, 7 };


			//var p = from item in a
			//		where item > 3
			//		orderby item
			//		select item;

			//foreach (var item in p)
			//{
			//	Console.WriteLine(item);
			//}

			//var phones = new List<Phone>();
			//var rand = new Random();

			//for (var i = 0; i < 10; i++)
			//{
			//	var phone = new Phone()
			//	{
			//		Name = "Name _ " + i,
			//		Price = rand.Next(10, 13)
			//	};
			//	phones.Add(phone);
			//}

			//foreach (var item in phones)
			//{
			//	Console.WriteLine(item);
			//}

			// Where

			////var res = phones.Where(item => item.Price > 12 )
			////Console.WriteLine();
			////foreach (var item in res)
			////{
			////	Console.WriteLine(item.Name + " - " + item.Price);
			////}

			//select
			//Console.WriteLine("select");
			//var res = phones.Where(item => item.Price > 11).Select(item => item.Name);

			//foreach (var item in res)
			//{
			//	Console.WriteLine(item);
			//}

			//orderby
			//Console.WriteLine("-----------------");
			//Console.WriteLine();
			//var res = phones.OrderBy(item => item.Price).ThenBy(item => item.Name);
			//foreach (var item in res)
			//{
			//	Console.WriteLine(item);
			//}

			Console.WriteLine("-----------------");
			Console.WriteLine();

			//var res = phones.FirstOrDefault();

			//var res = phones.GroupBy(item => item.Price);

			//foreach (var item in res)
			//{
			//	Console.WriteLine(item.Key);
			//	foreach (var val in item)
			//	{
			//		Console.WriteLine(val);
			//	}
			//}

			//Console.WriteLine(phones.All(item => item.Price == 11));
			//Console.WriteLine(phones.Any(item => item.Price == 11));

			//var newPhone = new Phone();

			//Console.WriteLine(phones.Contains(newPhone));

			//var array1 = new int[] { 1, 2, 3, 4 };
			//var array2 = new int[] { 3, 4, 5, 6 };
			//foreach (var item in array1)
			//{
			//	Console.WriteLine(item);
			//}
			//Console.WriteLine("-------");
			//foreach (var item in array2)
			//{
			//	Console.WriteLine(item);
			//}
			//Console.WriteLine("----Union---");


			//var union = array1.Except(array2);


			//foreach (var item in union)
			//{
			//	Console.WriteLine(item);
			//}

			//var sum = array2.Sum();
			//Console.WriteLine(sum);

			//var agr = array1.Aggregate((x, y) => x * y);
			//var array1 = new int[] { 1, 2, 3, 4 ,5,6,7};

			//	var val = array1.Skip(2).Take(4);
			//var single = array1.Single(p => p == 3);
			//var el = array1.ElementAt(3);

			//Console.WriteLine(el);
			


		}
	}
}
