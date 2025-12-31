# InventoryHub - Full-Stack Integration Project

InventoryHub è un'applicazione gestionale composta da un frontend in **Blazor WebAssembly** e un backend basato su **ASP.NET Core Minimal API**. Il progetto dimostra l'integrazione fluida tra client e server, ottimizzata tramite l'ausilio di Microsoft Copilot.

## 🚀 Caratteristiche principali
- **Comunicazione Full-Stack**: Integrazione completa tra Blazor e Minimal API.
- **Struttura Dati Avanzata**: Risposte API con oggetti JSON annidati (Categorie).
- **Debugging & Sicurezza**: Gestione corretta dei criteri CORS e delle eccezioni di rete.
- **Performance**: Implementazione di caching statico lato client per ridurre il carico sul server.
- **Error Handling**: Sistema di alert per gestire JSON malformati o errori di connessione.

## 🛠️ Tecnologie utilizzate
- **Frontend**: Blazor WebAssembly (.NET 8/9)
- **Backend**: ASP.NET Core Minimal API
- **Tooling**: Microsoft Copilot (per debugging e ottimizzazione), Postman (per validazione API).

## 📂 Struttura del Progetto
- `/ClientApp`: Applicazione frontend Blazor.
- `/ServerApp`: Backend Minimal API che fornisce l'endpoint `/api/productlist`.
- `REFLECTION.md`: Analisi dettagliata dell'esperienza di sviluppo con l'IA.

## ⚙️ Configurazione e Installazione

1. **Backend (ServerApp)**:
   - Naviga nella cartella `ServerApp`.
   - Esegui `dotnet run`.
   - Il server sarà attivo su `http://localhost:5013`.

2. **Frontend (ClientApp)**:
   - Naviga nella cartella `ClientApp`.
   - Esegui `dotnet run`.
   - L'applicazione sarà accessibile su `http://localhost:5148`.

## 🧠 Utilizzo di Microsoft Copilot
In questo progetto, Copilot è stato utilizzato per:
1. Generare il middleware per la risoluzione dei problemi **CORS**.
2. Identificare bug nella deserializzazione JSON tramite blocchi `try-catch` mirati.
3. Ottimizzare le performance suggerendo una strategia di **caching statico** per i prodotti.

---
*Progetto realizzato per il corso di Full-Stack Integration By Microsoft*