```mermaid

//titel is optioneel
---
Title: Prog Opdracht 13
---

//geef aan dat je een class diagram wil maken
classDiagram

//definieer je classes en bijhorende attributen en operaties
class Brute{
    + Health     //Private
}


//geef alle relaties aan
//Overerving Relatie
Brute --|> Unit

//Dependancy relatie
Unit ..> Brute
```