<div align="center">

![Workflow build](https://github.com/Acrozi/Personnummer-validation/actions/workflows/aws_deploy.yml/badge.svg)
![Workflow test](https://github.com/Acrozi/Personnummer-validation/actions/workflows/gh_pages_deploy.yml/badge.svg)
![Workflow test](https://github.com/Acrozi/Personnummer-validation/actions/workflows/unity_test.yml/badge.svg)

</div>

<div align="center">
  <h1>CesarAPI </h1>
</div>


## Introduktion

Denna .NET-baserade webbapplikation erbjuder funktioner för att kryptera och avkryptera ord med hjälp av ett alternativt Cesarchiffer. Applikationen innehåller två endpoints som kan nås via en webbläsare för att utföra dessa operationer. Dessutom har en HTML-sida och en JavaScript-fil laddats upp till GitHub Pages och AWS Amplify för att tillhandahålla en användargränssnitt för att visa hur man kan interagera med dessa endpoints. De båda endpointsen är också distribuerade på AWS Elastic Beanstalk för att säkerställa tillgänglighet och skalbarhet.

## Lokal Körning och Testning

För att köra och testa applikationen lokalt, följ stegen nedan:

1. Klona projektet från GitHub:
    bash
    `git clone https://github.com/NiklasAllard1/API-Encryption.git`

2. Navigera till projektmappen:
    `cd API-Encryption`

3. Öppna projektet i din C#-utvecklingsmiljö t.ex., Visual Studio eller VS Code.

4. Bygg projektet:
    `dotnet build`

5. Kör applikationen:
    `dotnet run`

6. När `dotnet run` körs skapar visual studio en lokal webbserver som går att öppna i webbläsaren för att testa följade endpoints. http://cesarapi-env.eba-jppdqkjp.eu-north-1.elasticbeanstalk.com/encrypt?text<YOURTEXT> - för att decrypta och http://cesarapi-env.eba-jppdqkjp.eu-north-1.elasticbeanstalk.com/decrypt?cipher=<YOURCIPHER> för att avkryptera.


7. Kör enhetstester:
    `dotnet test`

Se resultaten av enhetstesterna för att säkerställa korrekt funktionalitet.

## Körning med Docker


## Körning med .EXE


## Enhetstester

För att säkerställa korrekt funktionalitet har enhetstester skapats med hjälp av xUnit-ramverket. Enhetstestet validerar följande.

1. Validering av kryptering med testkryptering.

Projektet innehåller två projekt

CesarAPI: Huvudprojektet som innehåller kodfilen Startup.cs.
xUnitTest: Projektet som innehåller xUnit-testerna för att validera koden



## Övrig Information

För ytterligare detaljer och användning, se dokumentationen i källkoden och README.md filen i GitHub.
Lycka till med användningen av personnummerkontroll applikationen!

<div align="center">
  <h2>Collaborators</h2>
  <a href="https://github.com/Acrozi/Personnummer-validation/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=Acrozi/Personnummer-validation" />
  </a>
</div>
