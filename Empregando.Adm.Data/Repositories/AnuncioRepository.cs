using Empregando.Domain.Entities;
using Empregando.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Empregando.Data.Mappings;

namespace Empregando.Data
{
    public class AnuncioRepository : BaseRepository, IAnuncioRepository
    {
        public AnuncioRepository(IDbConnection connection) : base(connection)
        {
        }

        public void Atualizar(Anuncio anuncio)
        {
            var sql = @"UPDATE anuncios 
                        SET anuncio_ativo = @anuncio_ativo 
                        WHERE anuncio_id = @anuncio_id";

            Connection.Conn.Execute(sql, AnuncioAdapter.ToAnuncioMap(anuncio));
        }

        public Anuncio Obter(Guid id)
        {
            var sql = @"SELECT * 
                        FROM anuncios 
                        WHERE anuncio_id = @id";

            var map = Connection.Conn.Query<AnuncioMap>(sql, new { id }).FirstOrDefault();

            return AnuncioAdapter.ToAnuncio(map);
        }
    }
}
