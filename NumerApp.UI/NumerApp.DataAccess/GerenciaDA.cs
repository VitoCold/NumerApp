using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NumerApp.Entities;

namespace NumerApp.DataAccess
{
    public class GerenciaDA:BaseDA
    {
        IDbConnection Cnx;

        public int AddGerencia(Gerencia gerencia)
        {
            var result = 0;

            using (Cnx=new SqlConnection(GetCnxStringCartaDB))
            {
                var sql = "insert into Gerencia " +
                          "values(@apoderado,@nombreGerencia,@activo,@fechaIngreso,@abreviatura) ";

                result = Cnx.ExecuteAsync(sql,
                    new
                    {
                        apoderado = gerencia.Apoderado,
                        nombreGerencia = gerencia.NombreGerencia,
                        activo = true,
                        fechaIngreso = gerencia.FechaIngreso,
                        abreviatura=gerencia.Abreviatura
                    }).Result;
            }

            return result;
        }

        public int UpdateGerencia(Gerencia gerencia)
        {
            var result = 0;
            using (Cnx = new SqlConnection(GetCnxStringCartaDB))
            {
                var sql = "update Gerencia " +
                          "set Apoderado=@apoderado, " +
                          "NombreGerencia=@nombreGerencia, " +
                          "Activo=@activo, " +
                          "FechaIngreso = @fechaIngreso " +
                          "Abreviatura = @abreviatura " +
                          "where GerenciaId=@Id ";

                result = Cnx.ExecuteAsync(sql,
                    new
                    {
                        Id=gerencia.GerenciaId,
                        apoderado = gerencia.Apoderado,
                        nombreGerencia = gerencia.NombreGerencia,
                        activo = gerencia.Activo,
                        fechaIngreso = gerencia.FechaIngreso,
                        abreviatura=gerencia.Abreviatura
                    }).Result;
            }

            return result;
        }

        public IEnumerable<Gerencia> GetAll()
        {
            var result = new List<Gerencia>();
            using (Cnx = new SqlConnection(GetCnxStringCartaDB))
            {
                var sql = "select*from Gerencia ";

                result = Cnx.QueryAsync<Gerencia>(sql).Result.ToList();
            }

            return result;
        }


        public Gerencia Get(int id)
        {
            var result = new Gerencia();
            using (Cnx = new SqlConnection(GetCnxStringCartaDB))
            {
                var sql = "select*from Gerencia " +
                           "where GerenciaId=@Id ";

                result = Cnx.QueryAsync<Gerencia>(sql,new {Id=id}).Result.FirstOrDefault();
            }

            return result;
        }
    }
}
