# GymApp – Sistem pentru gestiunea unei rețele de săli de fitness

Aplicație WinForms (.NET 8) pentru gestionarea unei rețele de fitness:
- autentificare utilizatori
- administrare (CRUD) pentru abonamente, clase, antrenori, zone și săli
- client: cumpărare abonamente, rezervare clase, vizualizare/anulare rezervări, vizualizare săli (open/closed + VIP)
- persistență în fișiere JSON + tratare erori fișier/date invalide
- logging cu GenericHost + ILogger pentru acțiuni importante (login/abonamente/rezervări)

---

## Tehnologii
- C# / .NET 8
- WinForms (UI)
- Persistență: fișiere JSON
- Microsoft.Extensions.Hosting (GenericHost)
- Microsoft.Extensions.Logging (ILogger)

---

## Cum rulezi aplicația
1. Deschide soluția în Visual Studio.
2. Rulează proiectul (`F5`).
3. Se deschide ecranul de login.

### Conturi demo (users.json)
Exemplu:
- Admin: `admin / admin`
- Client: `client1 / 1234`

> Fișierele JSON sunt citite din folderul de output al aplicației (bin/...).

---

## Structură proiect (foldere)
- **Models/** – entități (Account, SubscriptionPlan, UserSubscription, FitnessClass, Booking, Trainer, Zone, Room etc.)
- **Data/** – utilitare pentru fișiere JSON (Load/Save cu tratare erori)
- **Controls/** – UserControls pentru fiecare pagină (CRUD + pagini client/admin)
- **Forms/** (sau root) – LoginForm, AdminForm, ClientForm

---

## Persistența datelor (fișiere JSON)
Aplicația salvează/încarcă automat datele în fișiere JSON. Exemple:
- `users.json` – conturi + rol
- `plans.json` – tipuri abonamente (Standard/VIP + validDays)
- `subscriptions.json` – abonamente cumpărate de utilizatori (Start/End)
- `classes.json` – clase (antrenor, capacitate, start, nivel acces)
- `bookings.json` – rezervări la clase
- `trainers.json` – lista antrenorilor
- `zones.json` – zone (program + acces)
- `rooms.json` – săli (zonă, capacitate, acces)

### Tratarea erorilor la fișiere
- dacă fișierul lipsește: aplicația pornește și creează liste goale / afișează mesaj
- dacă JSON e invalid: se afișează mesaj de eroare și se evită crash-ul aplicației (try/catch)

---

## Funcționalități – Administrator (AdminForm)

### 1) Administrarea abonamentelor (PlansControl)
- CRUD abonamente: adăugare / modificare / ștergere
- câmpuri: nume, preț, descriere, nivel acces (Standard/VIP), valabilitate (zile)

### 2) Gestionarea claselor (ClassesControl)
- CRUD clase: titlu, antrenor (selectat din ComboBox), durată, capacitate, start time
- nivel acces clasă: Standard/VIP

### 3) Gestionarea antrenorilor (TrainersControl)
- CRUD antrenori în `trainers.json`
- clasele folosesc lista de antrenori prin ComboBox

### 4) Administrarea zonelor și sălilor (ZonesControl, RoomsControl)
- Zone: CRUD + program (open/close hour) + acces (Standard/VIP)
- Rooms: CRUD + asociere cu zonă + capacitate + acces (Standard/VIP)

### 5) Vizualizare rezervări (AdminBookingsViewControl)
- listă clase cu număr rezervări / capacitate
- selectare clasă → afișare rezervări (username + timestamp)
- ștergere rezervare (admin)

### 6) Statistici (AdminStatsControl)
- abonamente active (count)
- rezervări totale
- top client (cele mai multe rezervări)
- ocupare pe clase (%)

---

## Funcționalități – Client (ClientForm)

### 1) Vizualizare abonamente + cumpărare (SubscriptionsControl)
- listă planuri disponibile
- cumpărare abonament → se creează intrare în `subscriptions.json`
- afișare abonamente active + istorice
- calcul DaysLeft și Status (Activ/Expirat)

### 2) Program clase + rezervare (ClientScheduleControl)
- vede programul claselor
- rezervare loc, în limita capacității
- verificări:
  - trebuie abonament activ
  - dacă clasa e VIP → trebuie plan VIP
  - nu permite rezervări duplicate

### 3) Rezervările mele (MyBookingsControl)
- afișează rezervări viitoare + trecute (Status: Viitoare/Trecută)
- anulare rezervare:
  - nu se poate anula cu mai puțin de 2 ore înainte
  - nu se poate anula după ce a început clasa

### 4) Vizualizare săli (ClientRoomsControl)
- listă săli cu zonă + capacitate + open/closed
- checkbox “doar deschise”
- sălile/zonele VIP apar cu “VIP (upgrade)” dacă utilizatorul nu are VIP

---

## Logging (GenericHost + ILogger)
Aplicația folosește `Microsoft.Extensions.Hosting` pentru configurare și `ILogger<T>` pentru logare.
Logurile apar în Output (Debug) în Visual Studio și ajută la debugging (login attempts, buy subscription, reserve/cancel booking, erori).

---

# Evoluția aplicației – GymApp

## Pasul 1 – Setup proiect + UI de bază
- Creat proiect WinForms (.NET 8)
- Structurat foldere: Models / Data / Controls / Forms
- Creat LoginForm + AdminForm + ClientForm
- Navigare între roluri după autentificare

## Pasul 2 – Persistență JSON
- Implementat utilitar JsonFile.Load/Save
- Salvare automată pentru entități (abonamente, clase, rezervări etc.)
- Tratare erori: fișiere lipsă / JSON invalid

## Pasul 3 – Admin CRUD
- Abonamente: CRUD (PlansControl)
- Clase: CRUD (ClassesControl)
- Antrenori: CRUD + ComboBox în clase (TrainersControl)
- Zone + Săli: CRUD + asociere zonă-sală (ZonesControl / RoomsControl)

## Pasul 4 – Client funcțional
- Client vede planuri + cumpără abonament (SubscriptionsControl)
- Client vede clase + rezervă loc (ClientScheduleControl)
- Client vede rezervările personale + anulare cu regulă (MyBookingsControl)
- Client vede săli + filtrare open/closed + VIP logic (ClientRoomsControl)

## Pasul 5 – Reguli business (validări)
- Rezervare permisă doar cu abonament activ
- Clase VIP rezervabile doar cu plan VIP
- Capacitate clase respectată (max locuri)
- Anulare rezervare interzisă cu <2h înainte

## Pasul 6 – Admin monitoring
- Admin vede rezervări pe fiecare clasă (AdminBookingsViewControl)
- Admin stats: abonamente active, total rezervări, ocupare clase, top client (AdminStatsControl)

## Pasul 7 – GenericHost + Logging
- Integrat .NET GenericHost pentru configurare și DI
- Adăugat ILogger pentru acțiuni importante:
  - login attempt/success/fail
  - cumpărare abonament
  - rezervare / anulare rezervare
- Loguri utile pentru debugging și urmărirea acțiunilor în aplicație


## Autori
Proiect realizat de Dumitrescu Alexandra, Drăgănescu Daniela Estera, Flueraș Emanuel.
