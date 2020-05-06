# BLSandbox 
Demoexemplen från [Websteps kompetenskväll i ämnet Blazor Server den 5/3 2020](https://www.youtube.com/watch?v=o406f2xR14s)

## TL;DR
* Första halvan av demot görs från ett nystartat Blazor-projekt
* Andra halvan visar följande:
  * Counter-sidan innehåller användning av en egen CounterService (Injected) för persistering av värdet.
  * Det finns en timer på Countersidan som regelbundet läser av värdet från CounterService och uppdaterar sidan (alla anslutna webbläsare uppdateras minst en gång i sekunden)
  * Counter-sidan har både @code i Razor-sidan och en CodeBehind-fil (partial-klass) för att demonstrera att bägge alternativen är möjliga
  * JSInterop-sidan demonstrerar tre olika interaktioner mellan Blazor-koden och Javascript (mer info i MS Dokumentationen - exemplen är i stort sett rakt av hämtade därifrån) 

## Länkar
* [Videoupptagning från kompetenskvällen (Youtube)](https://www.youtube.com/watch?v=o406f2xR14s)
* [Microsofts dokumentation Core 3.1 - Blazor](https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-3.1)
* [Blazing Pizza - app building workshop (Microsoft)](https://aka.ms/blazorworkshop)
* [.NET Conf Focus on Blazor (Youtube)](https://youtu.be/KlngrOF6RPw)
* [Developing interactive websites with C# using Blazor - Jimmy Engström @Swetugg2020 (Youtube)](https://youtu.be/idXQ4Hc3_dw) 
* [awesome-blazor (Github)](https://github.com/AdrienTorris/awesome-blazor)
