# BLSandbox 
Demoexemplen från Websteps kompetenskväll i Blazor Server 5/3 2020

## TL;DR
* Counter-sidan innehåller användning CounterService (Injected) för persistering av värdet.
* Det finns en timer på Countersidan som regelbundet läser av värdet från CounterService och uppdaterar sidan (alla anslutna webbläsare uppdateras minst en gång i sekunden)
* Counter-sidan har både @code i Razor-sidan och en CodeBehind-fil (partial-klass) för att demonstrera att bägge alternativen är möjliga

* JSInterop-sidan demonstrerar tre olika interaktioner mellan Blazor-koden och Javascript (mer info i MS Dokumentationen - exemplen är hämtade därifrån) 

## Länkar
* Videoupptagning från kompetenskvällen (Ännu inte tillgänglig)
* [Microsofts dokumentation Core 3.1 - Blazor](https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-3.1)
* [Blazing Pizza - app building workshop (Microsoft)](https://aka.ms/blazorworkshop)
* [.NET Conf Focus on Blazor (Youtube)](https://youtu.be/KlngrOF6RPw)
* [Developing interactive websites with C# using Blazor - Jimmy Engström @Swetugg2020 (Youtube)](https://youtu.be/idXQ4Hc3_dw) 
* [awesome-blazor (Github)](https://github.com/AdrienTorris/awesome-blazor)