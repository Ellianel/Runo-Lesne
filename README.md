[Dokumentacja_Projekt_Gry_RunoLesne.pdf](https://github.com/user-attachments/files/26156204/Dokumentacja_Projekt_Gry_RunoLesne.pdf)


Karta Koncepcyjna Projektu Informatycznego: Runo Leśne
DOC_ID: MZ-PROJ-2026-CONCEPT
Przedmiot: Realizacja Projektu Informatycznego
Zespół projektowy:

Ellianel– Lead Developer / Project Manager

Bengaloo – UI/UX Designer

Jarek – Logic Developer (Systemy RPG)

R3QU_111 – Logic Developer (Generacja Proceduralna)

Blaine_pl – QA Engineer / Tester


  1. Streszczenie (Abstract)
Niniejszy projekt zakłada implementację grywalnego prototypu gry typu Dungeon Crawler o tytule „Runo Leśne”. Gra osadzona jest w mrocznym świecie inspirowanym mitologią słowiańską oraz stylistyką low fantasy. Głównym celem dydaktycznym jest demonstracja biegłości w separacji logiki biznesowej od warstwy prezentacji (UI) w środowisku .NET 8.0 oraz silniku Godot. Produkt końcowy będzie oferował turowy system walki, proceduralną generację lochów oraz zaawansowany system rozwoju postaci oparty na unikalnej mechanice alchemii.
  2. Wstęp i Cel Pracy
Celem projektu jest stworzenie aplikacji demonstrującej dojrzałe podejście inżynierskie poprzez zastosowanie wzorców projektowych C# oraz testów jednostkowych.

Geneza: Potrzeba stworzenia gry o wysokim stopniu trudności taktycznej, nawiązującej do klasyków gatunku takich jak Darkest Dungeon .

Teza projektowa: Zastosowanie wzorców takich jak Factory i Strategy pozwoli na łatwe skalowanie poziomu trudności i dodawanie nowych typów przeciwników bez modyfikacji rdzenia silnika gry.
  3. Specyfikacja Techniczna i Architektura
Projekt zostanie zrealizowany w architekturze wielowarstwowej:

Logika Biznesowa (Core): Czysty C# (.NET 8.0) zawierający modele danych, kalkulatory walki i algorytmy generacji.

Prezentacja (View): Silnik Godot odpowiedzialny za renderowanie grafiki 2D i obsługę wejścia użytkownika.

Komunikacja: Wykorzystanie wzorca Observer (zdarzenia C#) do informowania UI o zmianach stanu gry (np. spadek HP).
  Zastosowane Wzorce Projektowe:
1.Singleton: Zarządzanie globalnym stanem sesji i zapisem gry.
2.Factory (Fabryka): Dynamiczne tworzenie obiektów przeciwników (np. Utopiec, Leszy).
3.Strategy (Strategia): Implementacja różnych typów ataków i efektów statusowych (np. krwawienie, zatrucie).
4. Mechanika Rozgrywki (Gameplay Loop)
Rozgrywka koncentruje się na eksploracji lochów podzielonych na pokoje, w których gracz napotyka wyzwania taktyczne.
System Walki: Turowy system oparty na Punktach Wigoru (3 PA na turę). Gracz musi balansować między atakiem, ruchem a regeneracją .
Przełamanie (Stun): Mechanika obniżania wytrzymałości wroga poprzez celowanie w słabe punkty (np. użycie srebra na upiory) .
Alchemia: Zamiast klasycznej many, gracz zarządza poziomem „Toksyczności” (Promili), pijąc wzmacniające nalewki, które niosą ryzyko debuffów wizualnych i mechanicznych.
5. Harmonogram Realizacji (Sprinty)
Prace zostaną podzielone na 4 główne etapy :
Sprint 1: Setup repozytorium, szkielet klas C# i podstawowe UI .
Sprint 2 (Poziom 3.0): Implementacja walki, zapisu JSON i stałej mapy pokoi .
Sprint 3 (Poziom 4.0): Proceduralna generacja lochów (algorytm dwuwymiarowych tablic) i system klas .4.
Sprint 4 (Poziom 5.0): System zadań, rzadkość łupu i finalny boss „Kolekcjoner” .

6. Podsumowanie i Oczekiwane Wyniki
Realizacja projektu pozwoli na uzyskanie stabilnej aplikacji, w której logika gry jest w pełni testowalna jednostkowo (Unit Tests). Spodziewanym rezultatem jest gra o wysokiej grywalności, spełniająca wymogi techniczne specyfikacji MZ-PROJ-2026, dokumentująca proces tworzenia oprogramowania w zespole programistycznym.
 

 test test 