Du ska skapa ett GitHub-projekt som demonstrerar de fyra OOP-principerna – men med versionshantering som en del av inlämningen.

📦 Struktur på projektet
Skapa en ny Console Application i C#
Lägg upp projektet på GitHub
På din main-branch ska du ha:
En grundläggande klass med enkel struktur (t.ex. Person, Account, Shape, etc.)
Inga OOP-principer implementerade än – bara en enkel klass med props och någon metod

🌿 Skapa sedan en branch för varje princip:

Branch namn - Vad du ska göra :
encapsulation - Visa inkapsling med private fält och public metoder
inheritance - Skapa en subklass som ärver från huvudklassen
polymorphism - Skapa virtuella/överskuggade metoder i flera klasser
abstraction - Använd en abstract klass och arv


🔀 Varje branch ska:

✅ Ha egna commit-meddelanden
✅ Ha tydliga kommentarer i koden
✅ När du är klar – skapa en Pull Request till main
✅ PR:n ska beskriva vilken princip du implementerat och vad du lärt dig


📌 Du ska alltså ha 4 olika Pull Requests – en för varje princip.


📝 Exempel på struktur:
main
BankAccount.cs (grundläggande klass utan OOP-principer)
encapsulation
Gör Balance privat, lägg till Deposit() och Withdraw()
inheritance
Lägg till SavingsAccount : BankAccount
polymorphism
Skapa virtual och override metoder
abstraction
Skapa abstract class Account och implementera den i underklasser