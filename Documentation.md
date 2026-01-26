# Specyfikacja Wymagań Oprogramowania (SRS) - Wise Finance

**Zespół projektowy:** Michael Moses, Yevhenii Kulikovskyi, Tomasz Ostrowski
**Link do repozytorium:** [Click](https://github.com/88Michael88/IO_Project)

---

## 1. Wstęp

### 1.1. Cel

Wise Finance 1.0

Dokument ma na celu...

### 1.2. Wizja, Zakres i Cele Produktu

**Wizja:** 
"Wise Finance" pomoże osiągnąć niezależność finansową naszym klientom.

**Zakres:**
System "Wise Finance" będzie realizował następujące procesy:
1.  Ewidencja przychodów i wydatków.
2.  Kategoryzacja transakcji.
3.  Zarządzanie budżetami miesięcznymi.
4.  Definiowanie i śledzenie celów oszczędnościowych.
5.  Raportowanie i wizualizacja danych finansowych.
6.  Zgromadzenie danych finansowych z różnych źródeł.

**Cele Biznesowe i Użytkowników (KPIs):**
1. Retencja: 30% użytkowników, którzy założyli konto, doda przynajmniej jedną transakcję w drugim miesiącu użytkowania.
2. Aktywność: Średnia liczba transakcji dodawanych przez aktywnego użytkownika wyniesie min. 15 miesięcznie.
3. Niezawodność: Dostępność systemu na poziomie 99.9% w godzinach szczytu (8:00 - 22:00).

**Poza Zakresem:**
1. System nie będzie doradzał klientom jak gospodarować bogactwem.
2. System nie będzie proponował budżetów.

### 1.3. Definicje, Akronimy i Skróty

Poniższa sekcja definiuje całą terminologię używaną w dokumencie SRS, dzieląc ją na pojęcia domenowe (biznesowe), techniczne oraz prawne.

#### Terminologia Biznesowa (Domenowa)

* **Budżet (Budget):** Zdefiniowany przez użytkownika limit finansowy przypisany do konkretnej **Kategorii** na określony **Okres Rozliczeniowy**. Przekroczenie budżetu jest sygnalizowane przez System (ostrzeżenie wizualne), ale nie blokuje technicznej możliwości dodawania nowych **Transakcji**.
* **Cel Oszczędnościowy (Savings Goal):** Wirtualna "skarbonka" w Systemie, posiadająca nazwę, docelową kwotę oraz (opcjonalnie) datę osiągnięcia celu.
* **Kategoria (Category):** Etykieta służąca do grupowania **Transakcji** (np. "Jedzenie", "Transport", "Wynagrodzenie"). Kategorie mogą być typu "Wydatek" lub "Przychód".
* **Okres Rozliczeniowy:** Przedział czasu, dla którego obliczany jest bilans i resetowane jest zużycie budżetów. W systemie Wise Finance domyślnym okresem jest jeden miesiąc kalendarzowy (od 1. do ostatniego dnia miesiąca).
* **Przychód (Income):** Typ transakcji zwiększający saldo użytkownika (np. wypłata, zwrot podatku, prezent).
* **Raport:** Zestawienie danych finansowych w formie graficznej (wykresy kołowe, słupkowe, liniowe) lub tabelarycznej, prezentujące strukturę wydatków i przychodów w wybranym okresie czasu.
* **Saldo Całkowite (Total Balance):** Matematyczna suma wszystkich środków pieniężnych posiadanych przez użytkownika, zarejestrowanych w systemie.
* **Saldo Wolne (Disposable Balance):** Kwota pieniędzy faktycznie dostępna do wydania na bieżące potrzeby. Obliczana jako: *Saldo Całkowite* minus środki przypisane do *Celów Oszczędnościowych* oraz minus planowane *Wydatki Stałe* do końca miesiąca.
* **Transakcja (Transaction):** Pojedyncze zdarzenie finansowe zarejestrowane w systemie, posiadające atrybuty: kwota, data, kategoria, opis (opcjonalnie). Może być **Przychodem** lub **Wydatkiem**.
* **Wydatek (Expense):** Typ transakcji pomniejszający saldo użytkownika.

#### Terminologia Projektowa i Techniczna

* **API (Application Programming Interface):** Interfejs programistyczny aplikacji; zestaw reguł, dzięki którym frontend (część wizualna) komunikuje się z backendem (serwerem i bazą danych).
* **CRUD (Create, Read, Update, Delete):** Akrostych określający cztery podstawowe operacje na danych, które system musi umożliwiać dla kluczowych obiektów (np. transakcji, budżetów).
* **Frontend:** Warstwa prezentacji systemu (interfejs użytkownika); część aplikacji uruchamiana w przeglądarce internetowej lub na urządzeniu mobilnym.
* **KPI (Key Performance Indicators):** Kluczowe Wskaźniki Efektywności; mierzalne wartości używane do oceny, czy system spełnia cele biznesowe zdefiniowane w sekcji 1.2.
* **MVP (Minimum Viable Product):** Minimalna Wersja Produktu; wersja aplikacji posiadająca tylko te funkcjonalności, które są krytyczne dla zaspokojenia podstawowych potrzeb użytkownika (priorytetowe w analizie MoSCoW/Fibonacci).
* **SRS (Software Requirements Specification):** Specyfikacja Wymagań Oprogramowania; niniejszy dokument stanowiący podstawę prac projektowych.
* **User Story (Historyjka Użytkownika):** Krótki opis funkcjonalności z perspektywy użytkownika końcowego, zapisany wg schematu: *Jako [rola], chcę [akcja], aby [korzyść]*.

#### Kwestie Prawne i Regulacyjne

* **EOG (EEA):** Europejski Obszar Gospodarczy. Obszar geograficzny, w obrębie którego muszą być fizycznie przechowywane dane osobowe użytkowników (wymóg prawny).
* **RODO (GDPR):** Rozporządzenie o Ochronie Danych Osobowych. Unijne prawo regulujące zasady przetwarzania danych osobowych, narzucające na System wymogi dotyczące m.in. szyfrowania danych, prawa do bycia zapomnianym i eksportu danych.

### 1.4. Przegląd Dokumentu

**Rozdział 2 (Opis Ogólny):** Przedstawia szeroki kontekst systemu, definiując główne moduły, klasy użytkowników oraz narzucone ograniczenia technologiczne i prawne.  
**Rozdział 3 (Wymagania Funkcjonalne):** Zawiera szczegółowy opis funkcji systemu w formie Historyjek Użytkownika wraz z Kryteriami Akceptacji oraz analizą MVP.  
**Rozdział 4 (Atrybuty Jakościowe):** Definiuje wymagania niefunkcjonalne, opisane za pomocą mierzalnych scenariuszy jakościowych i analizy kompromisów architektonicznych.  
**Rozdział 5 (Odkrywanie i Analiza Wymagań):** Zawiera analizę porównawczą konkurencji, która uzasadnia podjęte decyzje projektowe i pozycjonowanie produktu na rynku.  

---

## 2. Opis Ogólny

### 2.1. Główne Funkcje Produktu
* Moduł Transakcji (Wpływy/Wydatki)
* Moduł Budżetowania
* Moduł Celów Oszczędnościowych
* Moduł Raportowania i Wizualizacji
* Moduł Agregacji Danych z Innych Źródeł

### 2.2. Klasy Użytkowników
* **Użytkownik Standardowy:** 
    * Osoba fizyczna chcąca kontrolować swoje finanse osobiste. 
    * Posiada dostęp do własnych danych, edycji budżetu i raportów. 
    * Częstotliwość użycia: codzienna.
* **Administrator Systemu:** 
    * Personel techniczny odpowiedzialny za utrzymanie ciągłości działania serwisu.
    * Ma dostęp do zarządzania kopiami zapasowymi i zarządzania kontami użytkowników. 
    * Nie ma wglądu w dane finansowe użytkowników.

### 2.3. Ograniczenia projektowe
**Ograniczenie 1: Technologiczne**
* **Ograniczenie:** Aplikacja musi być dostępna jako webowa (SPA) i responsywna na mobile.
* **Źródło:** Wymogi rynkowe / Dostępność urządzeń użytkowników.
* **Wpływ na architekturę:** Konieczność użycia frameworka frontendowego.

**Ograniczenie 2: Prawne**
* **Ograniczenie:** Zgodność z RODO (przechowywanie danych w EOG).
* **Źródło:** Prawo UE.
* **Wpływ na architekturę:** Wybór serwerowni w Europie, szyfrowanie danych w bazie.

**Ograniczenie 3: Biznesowe (Budżetowe/Czasowe)**
* **Ograniczenie:** Wersja MVP musi powstać w 10 tygodni.
* **Źródło:** Czas trwania semestru / wymogi zaliczenia.
* **Wpływ na architekturę:** Rezygnacja z automatycznej integracji z bankami API.

**Ograniczenie 4: Ilość generowanych danych**
* **Ograniczenie:** System musi przedstawić wiarygodne dane użytkownikowi. Nie może zgubić transakcji lub ją policzyć dwa razy.
* **Źródło:** Użytkownicy będą zapisywać oraz importować ogromne ilości danych, a nasz system musi to zapisać.
* **Wpływ na architekturę:** 
    * Baza danych musi priorytetyzować spójność danych (Consistency) oraz dostępność (Availability).
    * Narzuca to konieczność wybrania bazy danych typu SQL.

### 2.4. Założenia projektowe
**Założenie 1: Zaangażowanie użytkownika**
* **Treść:** Użytkownicy będą wprowadzać wydatki manualnie na bieżąco (codziennie/raz na tydzień).
* **Ryzyko:** Użytkownicy szybko porzucą aplikację, jeśli proces będzie zbyt żmudny.
* **Plan walidacji:** Testy użyteczności prototypu UX – mierzenie czasu dodawania 1 wydatku (musi być < 10 sek).

**Założenie 2: Techniczne**
* **Treść:** System będzie w stanie obsłużyć duże ilość danych bez zauważalnych opóźnień. 
* **Ryzyko:** Jeśli baza danych nie obsłuży zapis oraz odczyt dużych ilości danych, to aplikacja będzie działać jakby była zawieszona. To może prowadzić do frustracji użytkowników.
* **Plan walidacji:**
    * **Co:** Sprawdzimy przepustowość naszej bazy danych.
    * **Jak:** Prosty skrypt zostanie napisany, który:
        * będzie zapisywał (INSERT) coraz więcej danych,
            * średni czas zapisu rekordu powinien wynosić do 10ms,
        * będzie czytał (SELECT) coraz więcej danych,
            * średni czas odczytu 100 rekordów powinien wynosić do 50ms.
    * **Kiedy:** Przy wyborze bazy danych.
    * **Kto:** Jeden z deweloperów.

---

## 3. Wymagania Funkcjonalne

### 3.1. Wprowadzanie miesięcznych zarobków i wydatków

**Opis:** Umożliwia użytkownikowi dodanie nowej transakcji (przychód lub wydatek) do systemu.

**Historyjka Użytkownika:**
> Jako użytkownik dbający o finanse,
> chcę szybko dodać paragon po zakupach,
> abym miał aktualny stan moich finansów.

**Cel Biznesowy:** 
Zbudowanie bazy danych do analizy finansowej.

**Kryteria Akceptacji:**
* **WF-TRANS-01: Dodanie wydatku (Scenariusz Główny)**
    * **Given:** Jestem zalogowany i widzę pulpit główny.
    * **When:** Wybieram opcję "Dodaj wydatek", wpisuję kwotę, datę i kategorię.
    * **Then:** Wydatek pojawia się na liście transakcji.
    * **And:** Saldo główne zostaje pomniejszone o wpisaną kwotę.

* **WF-TRANS-02: Błędna kwota (Scenariusz Alternatywny)**
    * **Given:** Jestem w formularzu dodawania transakcji.
    * **When:** Wpisuję ujemną kwotę lub litery w polu kwoty.
    * **Then:** Przycisk "Zapisz" pozostaje nieaktywny.
    * **And:** Wyświetla się komunikat walidacji.

### 3.2. Kategoryzowanie wydatków
**Opis:** Przypisywanie kolorowych etykiet do transakcji.

**Historyjka Użytkownika:** 
> Jako użytkownik,
> chcę nie tylko odróżnić swoje transakcje nazwami,
> ale też kolorami. 

**Cel biznesowy:** 
Ułatwić użytkownikowi rozpoznawanie oraz analizę transakcji,
co ma zachęcić do częstszego korzystania aplikacji.

**Kryteria Akceptacji:** 
* **WF-KAT-WYD-01: Dodanie etykiety z kolorem (Scenariusz Główny)**
    * **Given:** Wchodzę na stronę 
    * **When:** dodaję transakcję 
    * **And:** wybieram etykietę do transakcji
    * **And:** daję kolor etykiecie.
    * **Then:** transakcja zostanie zapisana z wybraną etykietą i kolorem
    * **And:** etykieta będzie widoczna przy transakcji

* **WF-KAT-WYD-02: Dodanie etykiety bez koloru (Scenariusz Alternatywny)**
    * **Given:** Wchodzę na stronę 
    * **When:** dodaję transakcję 
    * **And:** wybieram etykietę do transakcji
    * **Then:** transakcja zostanie zapisana z wybraną etykietą
    * **And:** transakcja będzie miała domyśli kolor.
    * **And:** etykieta będzie widoczna przy transakcji

* **WF-KAT-WYD-03: Nie dodanie etykiety (Scenariusz Alternatywny)**
    * **Given:** Wchodzę na stronę 
    * **When:** dodaję transakcję 
    * **And:** nie wybrać do etykietę do transakcji.
    * **Then:** transakcja zostanie zapisana bez etykiety.

### 3.3. Zarządzanie budżetami (Dodawanie budżetów)
**Opis:** Możliwość ustalenia limitu wydatków na daną kategorię w miesiącu.

**Historyjka Użytkownika:** 
> Jako użytkownik,
> chcąc mieć finansową niezależność,
> muszę zacząć panować nad pewnymi kategoriami zakupów,
> aby zacząć nad tym panować muszę ustalić limity.

**Cel biznesowy:**
Pomóc klientom kontrolować swój budżet w kluczowych miejscach
oraz ostrzeganie przed przekroczeniem limitu,
to zwiększy zaufanie do firmy i utrzyma klientów.

**Kryteria Akceptacji:** 
* **WF-CONT-BUD-01: Dodanie limitu na daną kategorię (Scenariusz Główny)**
    * **Given:** Wchodzę do zakładki "Budżet"
    * **And:** znajduję się w pod kategorii "Zarządzanie budżetem"
    * **When:** wybiorę opcję "Dodaj limit", ustalę limit na daną kategorię w konkretny miesiąc
    * **Then:** limit zostanie zapisany.
    
* **WF-CONT-BUD-02: Powiadomienie o zbliżeniu się do limitu**
    * **Given:** Ustalę limit na daną kategorię w konkretnym miesiącu
    * **When:** wydam 80% budżetu w danej kategorii 
    * **Then:** dostanę powiadomienie o zbliżeniu się do limitu.

* **WF-CONT-BUD-03: Powiadomienie o przekroczeniu limitu**
    * **Given:** Ustalę limit na daną kategorię w konkretnym miesiącu
    * **When:** wydam ponad 100% budżetu w danej kategorii 
    * **Then:** dostanę powiadomienie o przekroczeniu limitu

### 3.4. Cele oszczędnościowe
**Opis:** Definiowanie celu (np. "Wakacje") i kwoty docelowej.

**Historyjka Użytkownika:** 
> Jako użytkownik,
> chciałbym wyznaczyć widoczny cel oszczędnościowy z kwotą,
> aby mieć motywację i kontrolę nad oszczędnościami.

**Cel biznesowy:** 
Wspierać użytkowników poprzez wizualne cele oszczędnościowe,
które motywują do kontynuowania z naszymi usługami.

**Kryteria Akceptacji:** 
* **WF-GOAL-01: Ustalenie nowego celu oszczędnościowego**
    * **Given:** Wchodzę do zakładki "Budżet".
    * **And:** znajduję się w pod kategorii "Cel oszczędnościowy"
    * **When:** Wybieram opcję "Dodaj Cel", 
    * **And:** wpisuję kwotę jaką chce oszczędzić
    * **And:** datę do kiedy chcę osiągnąć cel 
    * **And:** ustalam nazwę celu
    * **Then:** cel pojawia się na liście celi oszczędnościowych.

### 3.5. Generowanie raportów i Wizualizacja danych
**Opis:** Prezentacja danych na wykresach oraz zestawienia tabelaryczne.

**Historyjka Użytkownika:** 
> Jako użytkownik,
> chciałbym w wizualny sposób przedstawić swoje dane,
> abym mógł przeanalizować i zobaczyć tendencje moich transakcji

**Cel Biznesowy:**
Zachęcić klientów do regularnego analizowania swoich finansów,
co pozwoli im podejmować lepsze decyzje finansowe.

**Kryteria Akceptacji:** 
* **WF-RAP-VI-01: Przedstawienie danych w formie wykresu (Scenariusz Główny)**
    * **Given:** Wchodzę do zakładki "Raporty"
    * **And:** posiadam transakcje
    * **When:** wybieram przedział czasowy
    * **Then:** system wyświetla wykres z wydatkami w danym przedziale czasowym

* **WF-RAP-VI-02: Przedstawienie danych w formie tabeli**
    * **Given:** Wchodzę do zakładki "Raporty"
    * **And:** posiadam transakcje
    * **When:** wybieram przedział czasowy 
    * **And:** wybieram opcję "Widok Tabelaryczny"
    * **Then:** system wyświetla listę transakcji w formie tabeli

* **WF-RAP-VI-03: Przedstawienie danych według kategorii**
    * **Given:** Wchodzę do zakładki "Raporty"
    * **And:** posiadam transakcje z przypisanymi kategoriami
    * **When:** wybieram opcję "Podziel na Kategorie"
    * **Then:** system wyświetla podział wydatków na kategorie

### 3.6. Etapowe ładowanie strony
**Opis:** Użytkownik widzi jak strona ładuje się etapami.

**Historyjka Użytkownika:**
> Jako użytkownik gdy załaduję stronę nie chcę czekać, 
> aż cała strona z danymi mi się załaduje,
> chciałbym widzieć etapowe (sukcesywne) załadowanie poszczególnych elementów.

**Cel Biznesowy:** 
Użytkownik nie myśli, że nasza strona zawiesza się lub ma jakieś problemy.

**Kryteria Akceptacji:**
* **WF-ETAP-01: Ładowanie etapami (Scenariusz Główny)**
    **Given:** Użytkownik wchodzi na naszą stronę albo aplikację mobilną.
    **When:** Użytkownik widzi jak etapowo ładuję się UI.
    **Then:** Ładują się etapami dane.
    **And:** Po załadowaniu danych ładują się wszystkie obliczenia wykonane na tych danych.

### 3.7. Priorytetyzacja Wymagań (Analiza MVP)

Poniższa tabela przedstawia analizę priorytetów dla zidentyfikowanych funkcjonalności systemu *Wise Finance*.
Do oceny wykorzystano skalę Fibonacciego (1, 2, 3, 5, 8, 13, 21), priorytet obliczono według wzoru:
`Priorytet = (Korzyść + Kara) / (Koszt + Ryzyko)`

| ID | Funkcjonalność | Korzyść (User Value) | Kara (Business Loss) | Koszt (Dev Effort) | Ryzyko (Complexity) | Priorytet | Decyzja (MVP) |
| :--- | :--- | :---: | :---: | :---: | :---: | :---: | :---: |
| **3.1** | **Wprowadzanie transakcji** | 21 | 21 | 5 | 2 | **6.00** | **TAK** |
| **3.2** | **Kategoryzowanie wydatków** | 13 | 8 | 3 | 1 | **5.25** | **TAK** |
| **3.5** | **Raporty i Wizualizacja** | 13 | 8 | 8 | 3 | **1.91** | **TAK** |
| **3.3** | **Zarządzanie Budżetami** | 8 | 5 | 5 | 3 | **1.63** | **TAK** |
| **3.4** | **Cele oszczędnościowe** | 5 | 3 | 3 | 2 | **1.60** | **MOŻE** |
| **2.1*** | **Agregacja danych z banków** | 13 | 5 | 21 | 13 | **0.53** | **NIE** |
| **3.6** | **Etapowe ładowanie strony** | 3 | 2 | 5 | 3 | **0.63** | **NIE** |

*\*Funkcjonalność wspomniana w Opisie Ogólnym, ale wykraczająca poza MVP ze względu na złożoność.*

#### Uzasadnienie wyboru zakresu MVP:
Na podstawie przeprowadzonej analizy ilościowej, do wersji **MVP (Minimum Viable Product)** zakwalifikowano funkcjonalności o współczynniku priorytetu powyżej **1.6**.

1.  **Fundament Systemu (3.1, 3.2):** Najwyższy wynik uzyskały funkcje wprowadzania i kategoryzacji transakcji. Są one niezbędne do działania aplikacji, bez danych wejściowych Aplikacja nie dostarcza żadnej wartości. Ryzyko techniczne jest tu niskie, a kara za brak tych funkcji krytyczna.
2.  **Wartość dla Użytkownika (3.5, 3.3):** Raporty oraz Budżety stanowią o "inteligencji" systemu. Chociaż ich koszt implementacji jest wyższy (biblioteki wykresów, logika limitów), korzyść dla użytkownika przeważa nad kosztami. To te funkcje odróżniają aplikację od zwykłego notatnika.
3.  **Funkcje odrzucone lub odłożone:**
    * **Agregacja danych (Automatyczna):** Mimo dużej korzyści, koszt i ryzyko (integracja z API bankowymi, PSD2) są zbyt wysokie na 10-tygodniowy projekt (zgodnie z Ograniczeniem 3).
    * **Etapowe ładowanie (3.6):** Jest to usprawnienie UX, które ma niską wartość biznesową w początkowej fazie. Zostanie zrealizowane dopiero po stabilizacji głównych funkcji.
    * **Cele oszczędnościowe (3.4):** Zostały oznaczone jako "MOŻE". Jeśli starczy czasu po implementacji Raportów i Budżetów, zostaną dodane, ponieważ są stosunkowo tanie w implementacji (niski koszt), ale nie są krytyczne dla podstawowego procesu kontroli wydatków.

## 4. Atrybuty Jakościowe (Wymagania Niefunkcjonalne)

### 4.1. Wybór i priorytetyzacja atrybutów
1.  **Bezpieczeństwo** 
    * Dane finansowe są krytyczne dla klienta oraz dla reputacji naszej firmy.
    * Nie możemy pozwolić na jakikolwiek wyciek danych, który by identyfikował naszych klientów oraz ich stan finansowy.
    * Nasze serwisy będą działać jedynie z protokołami wersji `Secure`.
2.  **Użyteczność**
    * Klienci muszą móc wprowadzać dane codziennie, często wiele razy, aby utrzymać aktualność budżetu.
    * Interface jest intuitywny: 
        * Nowy użytkownik powinien być w stanie dodać nową transakcję do 50 sekund.
        * Użytkownik z ponad 10 wpisanymi transakcjami powinien być w stanie dodać nową transakcję w mniej niż 15 sekund.
    * Logiczne ustawienie opcji: Nowy użytkownik powinien być w stanie poznać wszystkie główne opcje w ciągu pięciu minut eksplorowania aplikacji.
3.  **Wydajność** 
    * Dodając nową transakcję po zakupach oraz sprawdzając statystyki podczas codziennych czynności klient nie powinien być spowalniany przez działanie aplikacji.
    * Zapisywanie do 100 rekordów danych musi trwać:
        * 300ms średnio, a
        * 800ms powinien być dziewięćdziesiątym percentylem.
    * Odczyt danych musi trwać: 
        * 200ms średnio, a
        * 500ms powinien być dziewięćdziesiątym percentylem.
    * Wykresy muszą muszą być wstanie obsłużyć 100 rekordów w średnio 100ms.
4.  **Skalowalność**
    * Użytkownicy będą wprowadzali nowe transakcje wiele razy dziennie i chcieli widzieć statystyki ze swoich transakcji przez długi okres czasowy.
    * Aplikacja musi działać poprawnie przy ponad 10000 transakcjach przypisanych do przynajmniej 100 użytkowników.
    * System musi być gotowy do przyjmowania przynajmniej 1000 nowych transakcji dziennie.
5.  **Dostępność**
    * Użytkownicy będą chcieli dodawać transakcje i sprawdzać statystyki w różnych godzinach, kiedy będą wykonywać płatności i oczekują, że aplikacja także będzie wtedy dostępna.
    * Aplikacja musi być dostępna przez 99.9% czasu.
    * Przerwy techniczne nie mogą być dłuższe niż 1 godzina.
6.  **Przenośność**
    * Aplikacja powinna działać na wielu systemach i urządzeniach, aby użytkownicy mogli z niej korzystać na dowolnym dostępnym urządzeniu w momencie zrobienia transakcji i dodania jej do aplikacji.
    * System musi być tworzony bez uwzględnienia konkretnego środowiska i musi być testowany na co najmniej 3 różnych urządzeniach.
7. **Modyfikowalność**
    * Aplikacja musi otrzymywać nowe aktualizacje poprawiające istniejące systemy i dodające nowe funkcjonalności, aby pozyskiwać nowych klientów i utrzymywać użytkowników korzystających z aplikacji.
    * Architektura systemu musi zapewniać separację warstw, aby zmiany w interfejsie użytkownika nie wymuszały modyfikacji w logice biznesowej.

### 4.2. Scenariusze Jakościowe (Dla TOP 3)

**Scenariusz 1: Bezpieczeństwo (Poufność danych)**
| Element           | Opis |
| :---              | :--- |
| **Źródło bodźca** | Nieautoryzowany atakujący / wyciek bazy danych. |
| **Bodziec**       | Próba odczytu danych użytkowników bezpośrednio z bazy. |
| **Artefakt**      | Baza danych systemu Wise Finance. |
| **Środowisko**    | Normalna praca systemu, serwer produkcyjny. |
| **Reakcja**       | Dane są zaszyfrowane i niemożliwe do odczytania bez klucza. |
| **Miara reakcji** | 100% haseł zahaszowanych, dane wrażliwe (kwoty, opisy) szyfrowane algorytmem AES-256. |


**Scenariusz 2: Bezpieczeństwo (Szyfrowanie połączenia)**
| Element           | Opis |
| :---              | :--- |
| **Źródło bodźca** | Osoba pomiędzy klientem (end user), a naszym systemem.                                |
| **Bodziec**       | Próba odczytu komunikacji pomiędzy klientem, a naszym systemem.                       |
| **Artefakt**      | Połączenie pomiędzy klientem, a naszym serwerem.                                      |
| **Środowisko**    | Normalna praca systemu, serwer produkcyjny.                                           |
| **Reakcja**       | Każde połączenie z użytkownikiem jest szyfrowane.                                     |
| **Miara reakcji** | Każdy kanał komunikacji będze wykożystywał protokół wersji Secure. Każdy kanał będzie testowany, aby zweryfikować poprawność konfiguracji. |


**Scenariusz 3: Użyteczność (Logicznie ułożony interface)**
| Element           | Opis |
| :---              | :--- |
| **Źródło bodźca** | Klient.                                                                                                   |
| **Bodziec**       | Użytkownik będzie chciał wykonać jedną z podstawowych funkcji.                                            |
| **Artefakt**      | Graficzny Interface Użytkownika.                                                                          |
| **Środowisko**    | Normalna praca systemu, serwer produkcyjny.                                                               |
| **Reakcja**       | Jeśli użytkownik kliknie na zakładkę, to system powinien pokazać podkategorie.                            |
| **Miara reakcji** | Nowy użytkownik powinien poznać główne funkcjonalności systemu w ciągu pięciu minut eksplorowania systemu.|


**Scenariusz 4: Wydajność (Odczyt danych)**
| Element           | Opis |
| :---              | :--- |
| **Źródło bodźca** | Klient.                                                                                                   |
| **Bodziec**       | Klient włącza aplikację i otwiera kartę ze swoimi finasami.                                            |
| **Artefakt**      | Graficzny Interface Użytkownika, nasz serwer oraz bazę danych. |
| **Środowisko**    | Normalna praca systemu, serwer produkcyjny.                                                               |
| **Reakcja**       | System załaduje dane użytkownika w odpowiednich czasie. |
| **Miara reakcji** | 200ms będzie średnim czasem załadowania danych, a 500ms będzie dziewięćdziesiątym percentylem czasu.|


**Scenariusz 5: Wydajność (Zapis danych)**
| Element           | Opis |
| :---              | :--- |
| **Źródło bodźca** | Klient.                                                                                                   |
| **Bodziec**       | Klient zapisuje swoje finase.                                            |
| **Artefakt**      | Graficzny Interface Użytkownika, nasz serwer oraz bazę danych. |
| **Środowisko**    | Normalna praca systemu, serwer produkcyjny.                                                               |
| **Reakcja**       | System zapisze dane użytkownika w odpowiednim czasie. |
| **Miara reakcji** | 300ms będzie średnim czasem zapisu danych, a 800ms będzie dziewięćdziesiątym percentylem czasu.|


**Scenariusz 6: Wydajność (Generowanie Raportów)**
| Element           | Opis |
| :---              | :--- |
| **Źródło bodźca** | Klient.                                                                                                   |
| **Bodziec**       | Klient otwiera zakładkę "Raport" i wybiera jak chciałby przedstawić dane. |
| **Artefakt**      | Graficzny Interface Użytkownika. |
| **Środowisko**    | Normalna praca systemu, serwer produkcyjny.                                                               |
| **Reakcja**       | System wygeneruje odpowiedni raport.          |
| **Miara reakcji** | Raport na każde 100 rekordów będzie potrzebował średnio 100ms. |


### 4.3. Analiza kompromisów architektonicznych

1. **Bezpieczeństwo**
    * Szyfrowanie danych wymaga dodatkowej mocy obliczeniowej na serwerze bazy danych i serwerze aplikacji. Może to wpłynąć na opóźnienia, co utrudnia realizację celów wydajnościowych.
    * Szyfrowanie danych wrażliwych (kwoty, opisy) nie da się łatwo indeksować i przeszukiwać, co prowadzi do utraty możliwości wykonywania szybkich zapytań po stronie bazy danych.
    * Wdrożenie wysokich standardów bezpieczeństwa obniża komfort użytkowania, który musi przejść przez dodatkowe zabezpieczenia za każdym razem kiedy próbuje uzyskać dostęp do konta.

2. **Użyteczność**
    * Ukrywanie opcji, aby interfejs był wygodny dla nowych użytkowników zmusza zaawansowanych użytkowników do wykonania większej liczby kliknięć, aby dotrzeć do potrzebnych funkcji.
    * Aby ekran był czytelny ilość danych na jednym ekranie musi być jak najmniejsza. Użytkownik musi wtedy więcej przewijać, aby zobaczyć dokładniejsze statystyki.

3. **Wydajność**
    * Każdy nowy indeks w bazie danych przyspiesza szukanie danych, ale duża ilość indeksów spowalnia zapis danych.

---

## 5. Odkrywanie i Analiza Wymagań

### Identyfikacja Konkurencji/Wzorców

1.  **Monefy**
    * Konkurencja bezpośrednia.
    * Darmowa aplikacja mobilna, której priorytetem jest szybkość i łatwość obsługi.
    * Oferuje uproszczony system budżetowania oparty na wykresie kołowym (wizualizacja wydatków) oraz limity budżetowe z systemem ostrzeżeń.
    * Bardzo szybki proces dodawania transakcji, wymagający od użytkownika jedynie wprowadzenia kwoty i wybrania ikony.
    * Wybierana przez osoby, które chcą rejestrować wydatki natychmiast po ich wykonaniu i widzieć status budżetu bez konieczności głębszej analizy finansowej.
2.  **YNAB (You Need A Budget)**
    * Konkurencja bezpośrednia.
    * Rozbudowany, płatny system budżetowy działający wieloplatformowo (desktop/mobile).
    * Posiada zaawansowany system statystyk oraz funkcje dla zaawansowanych użytkowników (np. planer spłaty pożyczek, autorska metryka Age of Money). 
    * Oferuje integrację z bankami (automatyczny import transakcji) oraz własnoręczne wprowadzanie niestandardowych transakcji.
    * Wybierana przez osoby poszukujące potężnego narzędzia do szczegółowej analizy finansów i planowania długoterminowego w wolnym czasie.
3.  **Excel / Google Sheets**
    * Konkurencja pośrednia.
    * Uniwersalne arkusze kalkukacyjne.
    * Brak wbudowanej logiki budżetowej – użytkownik musi samodzielnie tworzyć system za pomocą formuł.Wymaga manualne wprowadzanie danych do tabel w wyznaczone miejsca.
    * Wymaga manualne wprowadzanie danych do tabel w wyznaczone miejsca.
    * Tabele i skomplikowane arkusze są trudne w obsłudze i słabo skalują się na mniejszych ekranach (smartfon, tablet).
    * Rozwiązanie dla entuzjastów "DIY" (zrób to sam), którzy cenią pełną niezależność, elastyczność i totalną kontrolę nad sposobem obliczania swoich finansów.
4.  **Aplikacje bankowe (np. mBank manager finansów)**
    * Konkurencja pośrednia.
    * Narzędzie ściśle zintegrowane z kontem bankowym użytkownika.
    * Oferują podstawowe moduły statystyk i budżetowania, zależne od konkretnego banku.
    * Zintegrowane z kontem bankowym, automatycznie wprowadza transakcje przeprowadzane za pomocą środków na tym koncie, ale nie pozwalają na dodawanie niestandardowych transakcji (w tym operacji gotówkowych).
    * Użytkownicy korzystają z nich "domyślnie" przy okazji posiadania konta, traktując je jako dodatek, a nie dedykowane narzędzie analityczne.
5.  **Revolut**
    * Wzorzec funkcjonalny.
    * Kompleksowa aplikacja finansowa.
    * Koncentruje się na płatnościach (konta wielowalutowe, przelewy natychmiastowe, inwestycje). Posiada moduły budżetowania, jednak nie są one głównym celem aplikacji.
    * Stanowi wzorzec projektowy dla interfejsu (UI). Ze względu na dużą popularność, zaadaptowanie podobnych rozwiązań wizualnych pozwoli użytkownikom szybciej zrozumieć obsługę naszej aplikacji (wykorzystanie nawyków użytkownika).

### 5.2 Tabela z kryteriami obejmującymi kluczowe aspekty
  
| Aplikacja | Model wprowadzania danych | UX: Dostępność i wygoda na różnych platformach | Czas dodawania transakcji | Funkcjonalność budżetowania | Funkcjonalność analityczna i statystyczna | Model biznesowy |
| :---              | :--- |:--- |:--- |:--- |:--- |:--- |
| **Wise Finance**      | Manualny                               | Aplikacja Webowa. Czysty i czytelny interfejs. | Niski (<10s) | Proste limity + Cele Oszczędnościowe | Dedykowane Wykresy + Tabele. Czytelna wizualizacja struktury wydatków i wpływów. | Darmowy |
| **Monefy**            | Manualny                               | Aplikacja Mobilna. Bardzo prosta i intuicyjna. | Bardzo niski (<5s) | Ostrzeżenia o limitach | Prosta wizualizacja procentowego udziału kategorii w wydatkach. | Darmowy z opcją premium |
| **YNAB**              | Manualny + Automatyczny                | Aplikacja Webowa i Mobilna. Bardzo rozbudowany i skomplikowany interfejs. | Niski (<10s) lub Zerowy (Automat) | Rygorystyczne (Zero-based Budgeting) | Zaawansowana analityka. Obejmuje wiele wykresów oraz unikalną metrykę "Age of Money". | Płatny (Subskrypcja) |
| **Excel / Sheets**    | Manualny                               | Program Komputerowy. Wygodny na dużym ekranie, ale na telefonie bardzo trudny w obsłudze | Zależny od implementacji użytkownika | Brak (Wymaga stworzenia formuł) | Własna konfiguracja. Użytkownik ma pełną swobodę tworzenia dowolnych wykresów, ale musi je sam zaprojektować. | Darmowy |
| **Aplikacje bankowe** | Automatyczny, podział na konta bankowe | Aplikacja Mobilna i Serwis WWW. Standardowa wygoda, ale interfejs często bywa "zaśmiecony" reklamami pożyczek i ofertami banku. | Zerowy (Automat) | Podstawowa (Zależna od banku) | Prosta historia transakcji. Zazwyczaj ogranicza się do listy przelewów i prostego podsumowania miesiąca. | Darmowy |
| **Revolut**           | Automatyczny, podział na konta bankowe | Aplikacja Mobilna. Nowoczesna i ładna, bardzo intuicyjna w obsłudze. | Zerowy (Automat) | Podstawowa (Kieszonki/Cele) | Interaktywne, atrakcyjne wizualnie wykresy.| Darmowy z opcją premium |

### 5.3 Synteza wyników ###
**Co konkurencja robi dobrze?**
1. Łatwość obsługi i szybkość interakcji (Monefy):
    * Największą zaletą liderów rynku aplikacji z manualnym wprowadzaniem danych jest minimalizacja liczby kliknięć. 
    * Użytkownik może dodać wydatek w mniej niż 5 sekund zaraz po jego wykonaniu, integrując wprowadzanie transakcji z dziennymi czynnościami.
2. Potężne narzędzia statystyczne (YNAB): 
    * Rozwiązania wykorzystywane w ofercie płatnej oferują wgląd w kondycję finansową wykraczający poza zwykłe sumowanie wydatków i tworzenie wykresów. 
    * Metryki takie jak "Age of Money" czy wykresy Wartości Netto w czasie pozwalają na zaawansowane planowanie długoterminowe.
3. Estetyka wizualna (Revolut): 
    * Wykorzystywanie interaktywnych i łatwo zrozumiałych wykresów oraz czytelnej kategoryzacji opartej na ikonach zachęca użytkowników do korzystania z oferowanych statystyk i zachęca do analizy danych.

**Gdzie są ich słabe punkty?**
1. Bariera wejścia (Excel i YNAB): 
    * Arkusze kalkulacyjne wymagają samodzielnego tworzenia formuł i są trudne do korzystania na urządzeniach mobilnych. 
    * YNAB narzuca zbyt rygorystyczną metodologię i wysoką cenę, co odstrasza początkujących użytkowników, którzy chcielby skorzystać z oferowanych funkcji statystycznych.
2. Ograniczenia platformowe (Monefy): 
    * Proste aplikacje mobilne często nie posiadają wersji webowej, co utrudnia głębszą analizę raportów na dużym ekranie.
3. Brak możliwości integracji wielu kont bankowych (Aplikacje bankowe, Revolut): 
    * Banki oferują doskonałą automatyzację, ale nie pozwalają na grupowanie danych z różnych kont w jedno miejsce. 
    * Użytkownicy muszą polegać na innych aplikacjach, aby grupować finanse z wielu kont bankowych.

**Jakie unikalne funkcje oferują?**
1. Wizualizacja postępów: Paski postępu przy budżetach (zamiast samych liczb) pozwalają szybciej ocenić stan finansów.
2. Szybkie wybieranie kategorii: Zastąpienie listy rozwijanej, siatka dużych ikon znacznie przyspiesza proces dodawania transakcji na ekranach dotykowych.
3. Wirtualne Cele Oszczędnościowe (Skarbonki): Funkcja znana z Revoluta, pozwalająca wirtualnie wydzielić część środków na konkretny cel (np. "Wakacje") pozwala na proste planowanie długoplanowe, niezależnie od celów oszczędnościowych.
4. Wbudowany kalkulator: Integracja prostego kalkulatora bezpośrednio w polu wpisywania kwoty (np. wpisanie "12 + 4.50"). Pozwala to użytkownikowi zsumować kilka pozycji z paragonu bez wychodzenia z aplikacji.

### 5. 4 Wnioski: ###

Na podstawie analizy konkurencji, Wise Finance pozycjonuje się w niszy "złotego środka":
1. Dostępność: W przeciwieństwie do Monefy (tylko mobile) i Excela (tylko desktop), Wise Finance będzie systemem webowym (RWD), dostępnym wygodnie na obu platformach.
2. Szybkość vs Analityka: Priorytetem jest szybkość dodawania transakcji zbliżona do Monefy, ale z analityką lepszą niż w aplikacjach bankowych.
3. Model: Rezygnujemy z automatycznej integracji bankowej (jak w YNAB), aby uniknąć barier prawnych i kosztowych, stawiając na prostotę manualnego wprowadzania danych.
4. Adaptacja Wzorców UX: Kluczem do sukcesu aplikacji manualnych jest minimalizacja kliknięć i prostota wprowadzania danych. Dlatego w Wise Finance zaadoptujemy siatkę ikon do wyboru kategorii oraz wprowadzimy wbudowany kalkulator w polach do wpisywania kwoty.


## Dodatki

### Dodatek A: Diagramy
* Diagram Przypadków Użycia (Use Case Diagram)
### Dodatek B: Persony Użytkowników

### Dodatek C: Kwestie do Rozwiązania
