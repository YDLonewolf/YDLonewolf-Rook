using System.Reflection;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;

namespace MyTrader;

[Injectable(TypePriority = OnLoadOrder.PostLoad + 2)]
public class RookPresetLocaleLoader(
    WTTServerCommonLib.WTTServerCommonLib wttCommon
) : IOnLoad
{
    public async Task OnLoadAsync(CancellationToken cancellationToken)
    {
        var assembly = Assembly.GetExecutingAssembly();

        await wttCommon.CustomWeaponPresetService.CreateCustomWeaponPresets(assembly);
        await wttCommon.CustomLocaleService.CreateCustomLocales(assembly);
    }
}
