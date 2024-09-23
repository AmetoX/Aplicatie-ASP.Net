//using Dapper;
//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataLibrary
//{
//	//o luam de pe static , atunci cand facem unit testting sa nu se salveze in baza de date
//	public class DataAccess
//	{
//		public List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
//		{
//			using (IDbConnection connection = new MySqlConnection(connectionString))
//			{
//				List<T> rows = connection.Query<T>(sql, parameters).ToList();// dataorita ca adaugam paremtri , ne protejeaza de sql injection
//				return rows;
//			}
//		}

//		public void SaveData<T>(string sql, T parameters, string connectionString)
//		{
//			using (IDbConnection connection = new MySqlConnection(connectionString))
//			{
//				connection.Execute(sql, parameters);			
//			}
//		}
//	}
//}