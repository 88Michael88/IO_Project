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

*Podrozdział 1*
*Podrozdział 2*
*Podrozdział 3*
*Podrozdział 4*
*Podrozdział 5*

---

## 2. Opis Ogólny

### 2.1. Główne Funkcje Produktu
* Moduł Transakcji (Wpływy/Wydatki)
* Moduł Budżetowania
* Moduł Celów Oszczędnościowych
* Moduł Raportowania i Wizualizacji
* Moduł Agregacji Danych z Innych Źródeł

### 2.2. Klasy Użytkowników
* **Użytkownik Standardowy:** opis
* **Administrator Systemu:** opis
patrz dodatek b 

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
* **Ograniczenie:** System musi przedstawić wiarygodne dany użytkownikowi. Nie może zgubić transakcji lub ją policzyć dwa razy.
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
* **Treść:** Użytkownicy 
* **Ryzyko:**
* **Plan walidacji:**
    * **Co:** Sprawdzimy przepustowość naszej bazy danych.
    * **Jak:** Prosty skrypt zostanie napisany, który:
        * będzie zapisywał (INSERT) coraz więcej danych,
        * będzie czytał (SELECT) coraz więcej danych.
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

**Cel Biznesowy:** Zbudowanie bazy danych do analizy finansowej.

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
**Kryteria Akceptacji:** 

* **WF-KAT-WYD-01: Dodanie etykiety z kolorem (Scenariusz Główny)**
    * **Given:** Wchodzę na stronę 
    * **When:** dodaję transakcję 
    * **Then:** wybieram etykietę do transakcji
    * **And:** daję kolor etykiecie.

* **WF-KAT-WYD-02: Dodanie etykiety bez koloru (Scenariusz Alternatywny)**
    * **Given:** Wchodzę na stronę 
    * **When:** dodaję transakcję 
    * **Then:** wybieram etykietę do transakcji

* **WF-KAT-WYD-02: Nie dodanie etykiety (Scenariusz Alternatywny)**
    * **Given:** Wchodzę na stronę 
    * **When:** dodaję transakcję 
    * **Then:** nie wybrać do etykietę do transakcji

### 3.3. Zarządzanie budżetami (Dodawanie budżetów)
**Opis:** Możliwość ustalenia limitu wydatków na daną kategorię w miesiącu.
**Historyjka Użytkownika:** 
**Kryteria Akceptacji (Gherkin):** 

### 3.4. Cele oszczędnościowe
**Opis:** Definiowanie celu (np. "Wakacje") i kwoty docelowej.
**Historyjka Użytkownika:** 
**Kryteria Akceptacji (Gherkin):** 

### 3.5. Generowanie raportów i Wizualizacja danych
**Opis:** Prezentacja danych na wykresach oraz zestawienia tabelaryczne.
**Historyjka Użytkownika:** 
**Kryteria Akceptacji (Gherkin):** 

### 3.6. Etapowe ładowanie strony

**Opis:** Użytkownik widzi jak strona ładuje się etapami.

**Historyjka Użytkownika:**
> Jako użytkownik gdy załaduję stronę nie chcę czekać, 
> aż cała strona z danymi mi się załaduje,
> chciałbym widzieć etapowe (sukcesywne) załadowanie poszczególnych elementów.

**Cel Biznesowy:** Użytkownik nie myśli, że nasza strona zawiesza się lub ma jakieś problemy.

**Kryteria Akceptacji:**

* **WF-ETAP-01: Ładowanie etapami (Scenariusz Główny)**
    **Given:** Użytkownik wchodzi na naszą stronę albo aplikację mobilną.
    **When:** Użytkownik widzi jak etapowo ładuję się UI.
    **Then:** Ładują się etapami dane.
    **And:** Po załadowaniu danych ładują się wszystkie obliczenia wykonane na tych danych.

### 3.6. Priorytetyzacja Wymagań (Analiza MVP)

jakaś tabelka

**Uzasadnienie wyboru MVP:**
---

## 4. Atrybuty Jakościowe (Wymagania Niefunkcjonalne)

### 4.1. Wybór i priorytetyzacja atrybutów
1.  **Bezpieczeństwo** (Dane finansowe są krytyczne).
2.  **Użyteczność** (Aplikacja musi być wygodna na mobile, żeby ludzie chcieli wpisywać wydatki).
3.  **Wydajność** (Raporty muszą generować się szybko).

### 4.2. Scenariusze Jakościowe (Dla TOP 3)

**Scenariusz 1: Bezpieczeństwo (Poufność danych)**
| Element | Opis |
| :--- | :--- |
| **Źródło bodźca** | Nieautoryzowany atakujący / wyciek bazy danych. |
| **Bodziec** | Próba odczytu danych użytkowników bezpośrednio z bazy. |
| **Artefakt** | Baza danych systemu Wise Finance. |
| **Środowisko** | Normalna praca systemu, serwer produkcyjny. |
| **Reakcja** | Dane są zaszyfrowane i niemożliwe do odczytania bez klucza. |
| **Miara reakcji** | 100% haseł zahaszowanych, dane wrażliwe (kwoty, opisy) szyfrowane algorytmem AES-256. |

### 4.3. Analiza kompromisów architektonicznych
* **Bezpieczeństwo vs Wydajność:** Szyfrowanie każdego rekordu w bazie spowolni wyszukiwanie i generowanie raportów, ale jest konieczne dla ochrony prywatności.
dodac

---

## 5. Odkrywanie i Analiza Wymagań

### 5.1. Analiza Porównawcza (Benchmarking)

**Analizowana konkurencja:**
1.  Excel / Google Sheets (Konkurencja pośrednia).
2.  YNAB (You Need A Budget) - lider rynku.
3.  Aplikacje bankowe (np. mBank manager finansów).
4.  dopisac

**Tabela porównawcza:**
zrobic tabele

**Wnioski:**
---

## Dodatki

### Dodatek A: Diagramy
* Diagram Przypadków Użycia (Use Case Diagram)
### Dodatek B: Persony Użytkowników

### Dodatek C: Kwestie do Rozwiązania
