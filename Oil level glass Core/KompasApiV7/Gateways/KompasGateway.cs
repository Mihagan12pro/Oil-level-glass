using Kompas6Constants;
using KompasAPI7;
using Oil_level_glass_Core.Data.Files;

namespace Oil_level_glass_Core.KompasApiV7.Gateways
{
    internal abstract record KompasGateway
    {
        public IKompasDocument? KompasDocument { get; init; }
    }
}
