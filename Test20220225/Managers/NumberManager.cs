using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Test20220225.Helpers;
using Test20220225.Models;


namespace Test20220225.Managers
{
    public class NumberManager
    {
        public List<NumberContent> GetNumberList()
        {
            string connStr = ConfigHelper.GetConnectionString();
            string commandText = $@"
                                    SELECT *
                                    FROM Test99DB
                                    ";
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand command = new SqlCommand(commandText, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        List<NumberContent> retList = new List<NumberContent>();
                        while (reader.Read())
                        {
                            NumberContent info = new NumberContent()
                            {
                                ID = (int)reader["ID"],
                                BaseNumber = (int)reader["BaseNumber"],
                                CoefficientNumber = (int)reader["CoefficientNumber"]
                            };
                            retList.Add(info);
                        }
                        return retList;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog("NumberManager.GetNumberList", ex);
                throw;
            }
        }
        public void CreateNumberContent(NumberContent model)
        {
            string connStr = ConfigHelper.GetConnectionString();
            string commandText = $@"
                                    INSERT INTO Test99DB
                                        (BaseNumber, CoefficientNumber)
                                    VALUES
                                        (@BaseNumber, @CoefficientNumber)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand command = new SqlCommand(commandText, conn))
                    {
                        conn.Open();

                        command.Parameters.AddWithValue("@BaseNumber", model.BaseNumber);
                        command.Parameters.AddWithValue("@CoefficientNumber", model.CoefficientNumber);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog("NumberManager.CreateNumberContent", ex);
                throw;
            }
        }
    }
}