#  Cybersecurity Awareness Bot

A beginner-friendly **C# console chatbot** designed to promote cybersecurity awareness while demonstrating clean code architecture, user interaction, and CI/CD practices.

---

##  Overview

The **Cybersecurity Awareness Bot** is a console-based application that interacts with users, answers predefined questions, and provides a structured, visually engaging interface.

It demonstrates:

* User input handling & validation
* Modular C# design (classes & methods)
* Console UI styling (colors, ASCII art)
* Audio integration using WAV files
* GitHub Actions CI pipeline

---

##  Features

✅ Personalized user interaction
✅ ASCII art logo header
✅ Welcome audio (WAV playback)
✅ Predefined chatbot responses
✅ Graceful handling of unknown input
✅ Structured and colored console UI
✅ Clean separation of concerns (no monolithic `Program.cs`)
✅ Continuous Integration with GitHub Actions

---

##  Supported Questions

You can ask:

* **"How are you?"**
* **"What's your purpose?"**
* **"What can I ask about?"**

If the bot doesn’t understand your question, it will respond with:

> *"I didn't quite understand that. Could you rephrase?"*

---

##  Project Structure

```
CyberSecurityBot/
│
├── .github/
│   └── workflows/
│       └── dotnet-ci.yml
│
├── CyberSecurityBot/
│   ├── Program.cs
│   ├── ChatBot.cs
│   ├── UIHelper.cs
│   ├── AudioPlayer.cs
│   ├── CyberSecurityBot.csproj
│   └── welcome.wav
│
├── .editorconfig
└── README.md
```

---

##  Getting Started

### 📋 Prerequisites

* [.NET SDK 8.0+](https://dotnet.microsoft.com/download)
* Git

---

###  Installation

```bash
git clone https://github.com/your-username/CyberSecurityBot.git
cd CyberSecurityBot
dotnet restore
```

---

###  Run the Application

```bash
dotnet run --project CyberSecurityBot
```

---

##  Audio Setup

Ensure the file:

```
welcome.wav
```

is located inside the project directory:

```
CyberSecurityBot/
```

If the file is missing, the app will continue running without audio.

---

##  UI Preview

```
===============================================
    Cybersecurity Awareness Bot 
===============================================

Enter your name: John

Hello, John! Ask me something.

> how are you?
[Bot] John, I'm just code, but I'm running perfectly! 
```

---

##  CI/CD with GitHub Actions

This project includes a CI pipeline that:

* ✅ Restores dependencies
* ✅ Checks code formatting (`dotnet format`)
* ✅ Builds the application
* ✅ Runs tests (if added later)

Workflow file:

```
.github/workflows/manual.yml
```

---

##  Code Quality

* Enforced formatting via `.editorconfig`
* Optional: Treat warnings as errors
* Designed for scalability and maintainability

---

## 📄 License

This project is licensed under the MIT License.

---

## 👨‍💻 Author

Developed as part of a learning project for building structured C# applications with CI/CD integration.

---

## ⭐ Acknowledgements

* .NET CLI & SDK
* GitHub Actions
* Open-source community

---


