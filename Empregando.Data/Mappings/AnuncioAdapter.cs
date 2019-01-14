using Empregando.Domain.Entities;

namespace Empregando.Data.Mappings
{
    public static class AnuncioAdapter
    {
        public static AnuncioMap ToAnuncioMap(Anuncio anuncio)
        {
            return new AnuncioMap()
            {
                anuncio_id = anuncio.Id,
                anuncio_ativo = anuncio.Ativo
            };
        }

        public static Anuncio ToAnuncio(AnuncioMap map)
        {
            return new Anuncio(map.anuncio_id, map.anuncio_ativo);
        }
    }
}