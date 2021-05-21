# Program stworzony na potrzeby zadania

## Spis treści 
* [Teść zadania](#tesc-zadania)
* [Screenshots](#screenshoots)

## Teść Zadania
Chciałbym abyś przygotował prostą aplikację konsolową, wpf albo windows forms - to już jak Ci wygodniej. Poniżej opiszę Ci co aplikacja ma robić:

1. Aplikacja powinna implementować 2 następujące klasy obiektów:
                a) klasa 'Towar' z następującymi property:
                - Nazwa - property typu string
                - Cena - property typu decimal
                - Opis - property typu klasa 'Opisy'
                b) klasa 'Opisy' z następującymi property:
                - A property typu string
                - B property typu string
2. Aplikacja ma zaczytywać plik csv (plik przykładowy do testów w załączniku) z rekordami danych zawierającymi odpowiednio pola: Nazwa, Cena, OpisA, OpisB i załadować je do List<Towar>(). Użytkownik powinien w interfejsie móc sam wskazać plik.
3. Po wczytaniu danych aplikacja powinna udostępnić 3 następujące funkcje:
                a) Zapisz do XML posortowane wg nazwy - po odpaleniu powinno posortować przy wykorzystaniu LINQ dane z List<Towar> wg property Nazwa i zapisać do pliku XML, a następnie otworzyć plik (struktura pliku xml poniżej).
                b) Zapisz do XML gdzie cena większa od - po odpaleniu powinno zapisać posortowane po property Cena od wartości najwyższej przy wykorzystaniu LINQ dane z List<Towar> i zapisać do pliku XML, a następnie otworzyć plik (struktura pliku xml poniżej).
                c) Wyszukaj frazę w opisie - po odpaleniu użytkownik powinien wpisać tekst i aplikacja powinna wyświetlić użytkownikowi w interfejsie wszystkie rekordy z List<Towar> których property Opis.A i / lub Opis.B zawierają tą frazę.


Poniżej struktura pliku xml:

<Plik>
<Towary>
<Towar>
<Nazwa></Nazwa>
<Cena></Cena>
<Opis>
<A></A>
<B></B>
</Opis>
</Towar>
<Towar>
<Nazwa></Nazwa>
<Cena></Cena>
<Opis>
<A></A>
<B></B>
</Opis>
</Towar>
</Towary>
</Plik>

## Screenshots
![Example screenshot](./zadanie_ss/ss1.png)
![Example screenshot](./zadanie_ss/ss2.png)
![Example screenshot](./zadanie_ss/ss3.png)
![Example screenshot](./zadanie_ss/ss4.png)
![Example screenshot](./zadanie_ss/ss5.png)