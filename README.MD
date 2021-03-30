## ASP.NET Core

#### Startup.cs
- Innehåller metoder som kallas på när "Host" byggts i program.cs, då kallas det på startup.cs metoder. Hanterar HTTP requests, 

#### wwwwroot
- Håller statiska filer, CSS, Javascript, bilder te.x.

---

## Razor Pages
#### Razor Pages skapas
- När vi skapar Razor Pages, så skapar vi en .cshtml fil och en cshtml.cs fil, .cshtml är vår frontend och cshtml.cs är vår backend. Val av "CRUD" ger oss möjligheten att få gratis kod, Create, Details, Edit, Delete och Index. Front och backend.

#### Syntax för Razor
- I Razor Pages kan vi lätt implementera C#-/backend kod genom att lägga till '@' följt av variabler eller funktioner. Exempel:
```html
<td>
    @Html.DisplayFor(modelItem => item.Event.Description)
</td>
```

---

## MVC
#### Models
- Här bygger vi upp klasser med våra olika tabeller och vad dessa tabellerna ska innehålla.
#### Views
- Vår User interface. Presenterar vår HTML kod.
#### Controller
- Hanterar vilken Views och Models som ska visas.