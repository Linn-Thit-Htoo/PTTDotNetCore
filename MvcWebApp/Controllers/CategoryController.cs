using Microsoft.AspNetCore.Mvc;
using MvcWebApp.Models.Entities;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace MvcWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IConfiguration _configuration;

        public CategoryController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            try
            {
                SqlConnection conn = new(_configuration.GetConnectionString("DbConnection"));
                conn.Open();
                string query = @"SELECT [CategoryId]
      ,[CategoryName]
      ,[IsActive]
  FROM [dbo].[Category] WHERE IsActive = @IsActive";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@IsActive", true);
                SqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                conn.Close();

                string jsonStr = JsonConvert.SerializeObject(dt);
                List<CategoryDataModel> lst = JsonConvert.DeserializeObject<List<CategoryDataModel>>(jsonStr)!;

                return View(lst);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [ActionName("CreateCategory")]
        public IActionResult GoToCreatePage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(CategoryDataModel model)
        {
            try
            {
                SqlConnection conn = new(_configuration.GetConnectionString("DbConnection"));
                conn.Open();
                string query = @"INSERT INTO Category (CategoryName, IsActive) VALUES (@CategoryName, @IsActive)";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@CategoryName", model.CategoryName);
                cmd.Parameters.AddWithValue("@IsActive", true);
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    TempData["success"] = "Creating Successful!";
                }
                else
                {
                    TempData["error"] = "Creating Fail!";
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
