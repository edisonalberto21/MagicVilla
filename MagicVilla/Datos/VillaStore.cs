using MagicVilla.Modelos.Dto;

namespace MagicVilla.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villalist = new List<VillaDto>
        {
            new VillaDto { Id = 1, Nombre = "Edison" },
            new VillaDto { Id = 2, Nombre = "Alberto"}
        };
    }
}
