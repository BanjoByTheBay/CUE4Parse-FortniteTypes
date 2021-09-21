using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FGameplayEffectApplicationInfo : IUStruct
    {
        public FSoftObjectPath GameplayEffect; // UClass
        public float Level;

        public FGameplayEffectApplicationInfo(FStructFallback fallback)
        {
            GameplayEffect = fallback.GetOrDefault<FSoftObjectPath>(nameof(GameplayEffect));
            Level = fallback.GetOrDefault<float>(nameof(Level));
        }
    }
}