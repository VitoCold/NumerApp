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
    public class CartaDA:BaseDA
    {
        IDbConnection Cnx;

        public int AddCarta(Carta carta)
        {
            var result = 0;

            using (Cnx = new SqlConnection(GetCnxStringCartaDB))
            {
                var sql = "insert into Carta " +
                          "values(@codigo,@gerenciaId,@asunto,@destinatario,@usuario,@fecha) ";

                result = Cnx.ExecuteAsync(sql,
                    new
                    {
                        codigo = carta.Codigo,
                        gerenciaId = carta.GerenciaId,
                        asunto = carta.Asunto,
                        destinatario = carta.Destinatario,
                        usuario=carta.Usuario,
                        fecha=carta.FechaCreacion
                    }).Result;
            }

            return result;
        }

        public int UpdateGerencia(Carta carta)
        {
            var result = 0;
            using (Cnx = new SqlConnection(GetCnxStringCartaDB))
            {
                var sql = "update Carta " +
                          "set Codigo=@codigo, " +
                          "GerenciaId=@gerenciaId, " +
                          "Asunto=@asunto, " +
                          "Destinatario = @destinatario " +
                          "Usuario=@usuario, " +
                          "FechaCreacion=@fecha " +
                          "where CartaId=@Id ";

                result = Cnx.ExecuteAsync(sql,
                    new
                    {
                        codigo = carta.Codigo,
                        gerenciaId = carta.GerenciaId,
                        asunto = carta.Asunto,
                        destinatario = carta.Destinatario,
                        usuario = carta.Usuario,
                        fecha = carta.FechaCreacion
                    }).Result;
            }

            return result;
        }

        public IEnumerable<Carta> GetAll()
        {
            var result = new List<Carta>();
            using (Cnx = new SqlConnection(GetCnxStringCartaDB))
            {
                var sql = "select*from Carta ";

                result = Cnx.QueryAsync<Carta>(sql).Result.ToList();
            }

            return result;
        }


        public Carta Get(int id)
        {
            var result = new Carta();
            using (Cnx = new SqlConnection(GetCnxStringCartaDB))
            {
                var sql = "select*from Carta " +
                           "where CartaId=@Id ";

                result = Cnx.QueryAsync<Carta>(sql, new { Id = id }).Result.FirstOrDefault();
            }

            return result;
        }
    }
}
