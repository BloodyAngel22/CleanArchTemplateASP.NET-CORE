# 🎯 **CleanArchTemplateASP.NET-CORE**

CleanArchTemplate is your new **superweapon** for building ASP.NET Core applications with a clean architecture! 🚀  
Want to start a new project without pain? Just use this template and enjoy clean, tidy and convenient. 

And yes, this project is still personal, but we all know that all great things start small..... 😏  

---

## ✨ **Features**  

- **Clean Architecture**: Separate logic, like a playlist of your favorite tracks. 🎵  
- **Preconfigured structure**: Take what you need, and use it! Everything you need is already there.  
- **Flexibility**: Add your code, because we don't mind limiting your creativity.  

---

## 🛠️ **Installation**

### 1. Install the template  
In the root directory of the template files, run:  
```bash
dotnet new install ./
```

### 2. Update if needed  
If you have already installed this template, just update it:  
```bash
dotnet new install --force ./
```

---

## 🎉 **How to use?**

Create a new project with one command:  
```bash
dotnet new cleanarch -n "YourProjectName"
```

You will get such a structure that will surprise you:  
```
YourProjectName/
├── YourProjectName.Core         👈 Your domain models and interfaces.
├── YourProjectName.Application  👈 Business logic, like a playlist of your favorite tracks.
├── YourProjectName.Infrastructure 👈 Everything related to databases and external APIs.
├── YourProjectName.WebApi        👈 Entry point. Hello, world! 🌍
└── YourProjectName.sln           👈 Convenient start for working in IDE.
```

---

## 📋 **Requirements**

- **.NET SDK 7.0+**: If you don't use the latest version, don't worry, you're a real programmer! 😏  
- Some knowledge of clean architecture. If not, don't worry, start with this template!  

---

## 💡 **How to use?**

1. **Install the template**:  
   ```bash
   dotnet new install ./
   ```
2. **Create a new project**:  
   ```bash
   dotnet new cleanarch -n "MyEpicProject"
   ```
3. **Open in your IDE**:  
   ```bash
   cd MyEpicProject
   code MyEpicProject.sln
   ```
4. **Run and enjoy**:  
   ```bash
   dotnet run --project MyEpicProject.WebApi
   ```

Now you have a project in your hands that looks like it was done by a team of experienced developers. 🔥  

---

## 🙌 **Contributions are welcome!**

This project is for personal use, but if you want to make your contribution, **welcome**! Fork, push, merge — we all here for improvements. 😎  

---

## 🐞 **Known issues**  

- Maybe, somewhere, you will have to correct the configuration manually. No worries, this is normal.  
- And yes, the project is still under development. So, if something goes wrong, it's just a bug. 😅  

---

## 📜 **License**  

This project is open for everyone and licensed under the MIT license. Read more in LICENSE.  

---