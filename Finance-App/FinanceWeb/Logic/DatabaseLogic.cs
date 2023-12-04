using FinanceWeb.Constants;
using Microsoft.EntityFrameworkCore;
using Model;
using MySqlConnector;
using Newtonsoft.Json;

namespace FinanceWeb.Logic
{
	public abstract class DatabaseLogic
	{
		private readonly string _connectionString = "server=localhost;user=root;database=financeapp;password=;";
		/// <summary>
		/// Get database connection
		/// </summary>
		/// <returns></returns>
		private MySqlConnection GetConnection()
		{
			MySqlConnection conn = new MySqlConnection(_connectionString);
			conn.Open();
			return conn;
		}

		/// <summary>
		/// Execute sql and return data from database
		/// </summary>
		/// <param name="sql"></param>
		/// <returns></returns>
		protected DatabaseResult GetDataReader(string sql)
		{
			DatabaseResult result = new DatabaseResult();
			MySqlCommand cmd = new MySqlCommand(sql, GetConnection());
			using (MySqlDataReader rdr = cmd.ExecuteReader())
			{
				while (rdr.Read())
				{
					var rowObject = new object[rdr.FieldCount];
					rdr.GetValues(rowObject);
					result.Data.Add(rowObject);
				}
				if (result.Data.Count == 0)
				{
					result.LastInsertedId = cmd.LastInsertedId;
				}

				rdr.Close();
				return result;
			}
		}

		/// <summary>
		/// Get data by id
		/// </summary>
		/// <param name="table"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		protected List<Object[]> GetById(string table, int id)
		{
			string sql = $"SELECT * FROM {table} where ID = {id}";
			var data = GetDataReader(sql);

			return data.Data;
		}

		/// <summary>
		/// Get data by id's
		/// </summary>
		/// <param name="table"></param>
		/// <param name="ids"></param>
		/// <returns></returns>
		protected List<Object[]> GetByIds(string table, List<int> ids)
		{
			string idString = string.Join(",", ids.Select(id => id.ToString()));

			string sql = $"SELECT * FROM {table} where ID in ({idString})";
			var data = GetDataReader(sql);

			return data.Data;
		}


		/// <summary>
		/// Delete record by ID
		/// </summary>
		/// <param name="table"></param>
		/// <param name="ids"></param>
		protected void DeleteByIds(string table, List<int> ids)
		{
			string idString = string.Join(",", ids.Select(id => id.ToString()));

			string sql = $"DELETE FROM {table} where ID in ({idString})";
			GetDataReader(sql);
		}
	}
}
