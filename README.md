Aplikacja została napisana w języku C# przy pomocy Visual Studio 2017 Community z dodatkiem MySQL Connector Net.
Przy pomocy aplikacji można połączyć się z każdą bazą danych MySQL, z której pobrane zostają tablice i rekordy. 
Aplikacja umożliwia dodawanie, edytowanie oraz usuwanie rekordów.

Działanie aplikacji
Po wprowadzeniu danych połączenia i wciśnięciu przycisku Connect aplikacja przesyła otrzymane dane do obiektu DBConnect, 
którym posługujemy się do wykonywania określonych zadań na bazie. Po przesłaniu danych aplikacja nawiązuje połączenie 
z bazą i pobiera z niej dane(tablice wraz z zawartością), które przypisuje do dropdownList(ComboBox). Defaultowo wybrana zostaje pierwsza 
alfabetycznie tablica, z której dane są pobierane i wyświetlane w ListView. Przyciski służące do edytowania oraz usuwania rekordów mają 
ustawioną wartość false do momentu wybrania jakiegoś rekordu z tabeli, jeśli chodzi o przycisk dodawania, jest on dostępny jeśli w bazie 
danych znajdują sie jakiekolwiek tabele. Po wybraniu opcji dodawania lub edytowania wyświetlone zostaje nowe okno, w którym określamy dane. 
Przy zmianie wyboru tabeli, aplikacja po wyczyszczeniu ListView pobiera rekordy nowej tabeli i wprowadza je do obiektu. Jeśli w polach aplikacji 
wyczyścimy dane, zostaną one zastąpione szarymi placeholderami, które znikną wraz z rozpoczęciem podawania nowych danych i będą pomocne dla przeciętnego użytkownika.