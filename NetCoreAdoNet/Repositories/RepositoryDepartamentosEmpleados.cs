using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetNombreDepartamentosAsync()
        {
            string sql = "select DNOMBRE from DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> nombres = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string name = this.reader["DNOMBRE"].ToString();
                nombres.Add(name);
            };
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return nombres;
        }

        public async Task<List<string>> 
            GetApellidosEmpleadosAsync(string nombreDepartamento)
        {
            string sql = "select EMP.APELLIDO from EMP "
                + " inner join DEPT "
                + " on EMP.DEPT_NO = DEPT.DEPT_NO"
                + " where DEPT.DNOMBRE = @departamento";
            SqlParameter pamDept = new SqlParameter("@departamento", nombreDepartamento);
            this.com.Parameters.Add(pamDept);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> apellidos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string ape = this.reader["APELLIDO"].ToString();
                apellidos.Add(ape);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return apellidos;
        }

        public async Task DeleteEmpleadoAsync(string apellido)
        {
            string sql = "delete from EMP where APELLIDO=@apellido";
            SqlParameter pamApe = new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(pamApe);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
