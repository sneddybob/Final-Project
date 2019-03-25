using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Finalizer.Models
{
    public class ABCReportModel
    {
        public int OrderID { get; set; }
        public string Name { get; internal set; }
        public string BizSt { get; internal set; }
        public string BizCity { get; internal set; }
        public string BizZip { get; internal set; }
        public string BizState { get; internal set; }
        public string ShipSt { get; internal set; }
        public string ShipCity { get; internal set; }
        public string ShipState { get; internal set; }
        public string ShipZip { get; internal set; }
    }
}


namespace Finalizer.Controllers
{
    public class ABCReportController : Controller
    {
        private SqlConnection _connection;

        public ABCReportController(System.Data.SqlClient.SqlConnection connection)
        {
            this._connection = connection;
        }
        public IActionResult Index()
        {
            ABCReportModel model = new ABCReportModel();

            
            {
                _connection.Open();
                System.Data.SqlClient.SqlCommand command = _connection.CreateCommand();
                command.CommandText = "SP_ABC_Receipt";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@OrderID", 1);

                System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                System.Data.DataSet dataSet = new System.Data.DataSet();
                adapter.Fill(dataSet);

                model.OrderID = (int)dataSet.Tables[0].Rows[0][0];
                model.Name = (string)dataSet.Tables[0].Rows[0][2];
                model.BizSt = (string)dataSet.Tables[0].Rows[0][3];
                model.BizCity = (string)dataSet.Tables[0].Rows[0][4];
                model.BizState = (string)dataSet.Tables[0].Rows[0][5];
                model.BizZip = (string)dataSet.Tables[0].Rows[0][6];

                model.ShipSt = (string)dataSet.Tables[1].Rows[0][3];
                model.ShipCity = (string)dataSet.Tables[1].Rows[0][4];
                model.ShipState = (string)dataSet.Tables[1].Rows[0][5];
                model.ShipZip = (string)dataSet.Tables[1].Rows[0][6];



                _connection.Close();
            }
            return View(model);
        }
    }
}