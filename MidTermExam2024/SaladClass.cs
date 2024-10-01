using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace MidTermExam2024
{

    public class SaladClass
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        string strSQL;

        public DataSet SaladSelect()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SaladSelect";

            DataSet myDs = objDB.GetDataSet(objCommand);

            return myDs;

        }

        public DataSet CustomerSelect()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CustomerSelect";

            DataSet myDs = objDB.GetDataSet(objCommand);

            return myDs;

        }

        public void SaladInsert(string saladSelection,string saladDressing, string SaladAddOns)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType= CommandType.StoredProcedure;
            objCommand.CommandText = "SaladInsert";

            SqlParameter inputparameterSelection = new SqlParameter("@EnterSaladSelection", saladSelection);
            objCommand.Parameters.Add(inputparameterSelection);

            SqlParameter inputparameterDressing = new SqlParameter("@EnterSaladDressing", saladDressing);
            objCommand.Parameters.Add(inputparameterDressing);

            SqlParameter inputparameterAddOns = new SqlParameter("@EnterSaladAddOns", SaladAddOns);
            objCommand.Parameters.Add(inputparameterAddOns);

            //SqlParameter inputparameterCustomerId = new SqlParameter("@EnterCustomerId", customerId);
            //objCommand.Parameters.Add(inputparameterCustomerId);

            objDB.DoUpdate(objCommand);
        }

        public void CustomerInsert(string customerName, string date, string status)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CustomerInsert";

            SqlParameter inputparametercustomerName = new SqlParameter("@EnterCustomerName", customerName);
            objCommand.Parameters.Add(inputparametercustomerName);

            SqlParameter inputparameterdate = new SqlParameter("@EnterDate", date);
            objCommand.Parameters.Add(inputparameterdate);

            SqlParameter inputparameterStatus = new SqlParameter("@EnterStatus", status);
            objCommand.Parameters.Add(inputparameterStatus);

            objDB.DoUpdate(objCommand);
        }

        public void CustomerUpdate(int customerId, string status)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CustomerUpdate";

            SqlParameter inputparametercustomerId = new SqlParameter("@EnterCustomerId", customerId);
            objCommand.Parameters.Add(inputparametercustomerId);

            SqlParameter inputparameterstatus = new SqlParameter("@EnterStatus", status);
            objCommand.Parameters.Add(inputparameterstatus);

            objDB.DoUpdate(objCommand);
        }

    }
}