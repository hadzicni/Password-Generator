# 🔐 Password Generator

A powerful yet easy-to-use WPF application for generating secure passwords. Built with .NET 8 and C#, it features customizable character options, real-time strength evaluation, and one-click clipboard support — perfect for developers, sysadmins, or anyone needing strong credentials.

![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)
![License](https://img.shields.io/badge/license-MIT-green)
![UI](https://img.shields.io/badge/UI-WPF-informational)

---

## ✨ Features

- 🔁 Instantly generate strong random passwords
- 🔣 Customizable: uppercase, lowercase, digits, symbols
- 📏 Adjustable length via slider
- 📋 One-click copy to clipboard
- 🧠 Strength bar with color-coded feedback
- 🧰 Optional "select all" checkbox for convenience
- ℹ️ Info window with GitHub link

---

## 📦 Installation & Running

### Requirements

- Windows 10 or later
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022+ (or any WPF-compatible IDE)

### 🔧 Build & Run with Visual Studio

1. Clone the repository:
   ```bash
   git clone https://github.com/hadzicni/Password-Generator.git
   cd Password-Generator
   ```

2. Open `PasswordGenerator.csproj` in Visual Studio.

3. Press `F5` or click **Start** to run the app.

---

### 🛠️ Build via CLI

```bash
dotnet build
dotnet run --project PasswordGenerator
```

---

## 🚀 Usage

1. Launch the app.
2. Use the slider to choose desired password length.
3. Select which character groups to include:
   - Uppercase (A–Z)
   - Lowercase (a–z)
   - Digits (0–9)
   - Symbols (!@#$…)
4. Click **Generate** to get a password.
5. Copy it with **Copy to Clipboard**.
6. View strength estimation directly below.

---

## 🖼️ UI Preview

> Coming soon.

---

## 👨‍💻 Author

Made by **Nikola Hadzic**  
GitHub: [@hadzicni](https://github.com/hadzicni)

---

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.
