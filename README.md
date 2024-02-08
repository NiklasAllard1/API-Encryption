<div align="center">

![Workflow build](https://github.com/NiklasAllard1/API-Encryption/actions/workflows/aws_deploy.yml/badge.svg)
![Workflow test](https://github.com/NiklasAllard1/API-Encryption/actions/workflows/gh_pages_deploy.yml/badge.svg)
![Workflow test](https://github.com/NiklasAllard1/API-Encryption/actions/workflows/unity_test.yml/badge.svg)

</div>

<div align="center">
  <h1>CesarAPI </h1>
</div>

<div style="text-align: center;">
  <h2>Services Used</h2>
  <a href="https://niklasallard1.github.io/API-Encryption/">
    <img src="https://pages.github.com/images/logo.svg" alt="GitHub Pages" style="width: 100px; height: auto; margin: 10px;">
  </a>
  <a href="länk-till-AWS-Elastic-Beanstalk">
    <img src="länk-till-beanstalk-logotyp" alt="AWS Elastic Beanstalk" style="width: 100px; height: auto; margin: 10px;">
  </a>
  <a href="länk-till-AWS-Amplify">
    <img src="länk-till-amplify-logotyp" alt="AWS Amplify" style="width: 100px; height: auto; margin: 10px;">
  </a>
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

6. När `dotnet run` körs skapar visual studio en lokal webbserver som går att öppna i webbläsaren för att testa följade endpoints. http://cesarapi-env.eba-jppdqkjp.eu-north-1.elasticbeanstalk.com/encrypt?text=Default - för att decrypta och http://cesarapi-env.eba-jppdqkjp.eu-north-1.elasticbeanstalk.com/decrypt?cipher=Gjifxqw för att avkryptera.


7. Kör enhetstester:
    `dotnet test`

Se resultaten av enhetstesterna för att säkerställa korrekt funktionalitet.

## Enhetstester

För att säkerställa korrekt funktionalitet har enhetstester skapats med hjälp av xUnit-ramverket. Enhetstestet validerar följande.

1. Validering av kryptering med testkryptering.

Projektet innehåller två projekt

CesarAPI: Huvudprojektet som innehåller kodfilen Startup.cs.
xUnitTest: Projektet som innehåller xUnit-testerna för att validera koden



## Övrig Information

Projektet initierades med målet att utforska och lära sig om Continuous Integration (CI) och Continuous Deployment (CD) processerna inom ramen för ett praktiskt projekt. Det fokuserar på att tillämpa dessa processer i praktiken genom att skapa och distribuera en .NET-baserad webbapplikation. Genom att genomföra CI/CD-processen i projektet får deltagarna möjlighet att förstå och tillämpa bästa praxis för att automatisera bygg-, test- och distributionsprocesserna för att uppnå snabbare och mer pålitliga utvecklingscykler.

för mer information om CI/CD processen klicka in på 
https://www.figma.com/file/siwE10NkNq1SK4K2aSje8l/API-Projekt?type=whiteboard&node-id=1%3A9093&t=3znLxSMkrLpgaitR-1

För att se min frontend klicka in på någon av dessa länkar
https://niklasallard1.github.io/API-Encryption/
https://developer.d3khin5f4ob0id.amplifyapp.com/

För att testa endpoints klicka in på 
http://cesarapi-env.eba-jppdqkjp.eu-north-1.elasticbeanstalk.com/encrypt?text=Default - för att decrypta 
http://cesarapi-env.eba-jppdqkjp.eu-north-1.elasticbeanstalk.com/decrypt?cipher=Gjifxqw för att avkryptera.

<div style="text-align: center;">
  <h2>Meet the maker</h2>
  <a href="https://github.com/NiklasAllard1/API-Encryption/graphs/contributors">
    <img src="https://github.com/niklasallard1.png" />
  </a>
</div>

