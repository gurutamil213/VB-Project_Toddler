# Toddler Learning App

A Windows Forms educational application built with **VB.NET** for toddlers and young children. The application provides a simple visual learning interface for exploring **fruits, vegetables, animals, and birds**, with an administrator/editor area for managing the learning content.

## ✨ Features

- 🔐 **Login-protected content management**
- 📚 **Learning dashboard** with four categories:
  - Fruits
  - Vegetables
  - Animals
  - Birds
- 🖼️ **Image-based learning** with support for JPG, PNG, and GIF images
- 🔎 **View detailed information** for each learning item
- ✏️ **Add and update catalog records**
- 🗑️ **Delete catalog records**
- 📂 **Automatic image storage** in a local `photos` folder
- 💾 **Microsoft Access database** for storing catalog information
- 🖥️ Built as a classic **Windows Forms desktop application**

## 🛠️ Technology Stack

| Technology | Details |
|---|---|
| Language | VB.NET |
| UI Framework | Windows Forms |
| .NET | .NET Framework 4.0 Client Profile |
| Platform | Windows |
| Database | Microsoft Access (`.accdb`) |
| Database Access | `System.Data.OleDb` / Microsoft ACE OLE DB |
| IDE | Visual Studio |

## 📁 Project Structure

```text
Toddler/
├── App.config
├── Toddler.vbproj
├── toddler.accdb
│
├── dashboard.vb
├── dashboard.Designer.vb
├── dashboard.resx
│
├── Login_form.vb
├── Login_form.Designer.vb
├── Login_form.resx
│
├── Learn_form.vb
├── Learn_form.Designer.vb
├── Learn_form.resx
│
├── Edit_form.vb
├── Edit_form.Designer.vb
├── Edit_form.resx
│
├── toddlerDataSet.xsd
├── toddlerDataSet.Designer.vb
│
└── My Project/
    ├── Application.myapp
    ├── Application.Designer.vb
    ├── AssemblyInfo.vb
    ├── Resources.resx
    ├── Resources.Designer.vb
    ├── Settings.settings
    └── Settings.Designer.vb
```

### Main Forms

- **`dashboard.vb`** – Main application dashboard and navigation.
- **`Learn_form.vb`** – Displays learning categories and item details.
- **`Login_form.vb`** – Provides access to the protected editing area.
- **`Edit_form.vb`** – Manages catalog records and images.

## 🚀 Getting Started

### Prerequisites

This project targets an older Windows/.NET stack, so the following are recommended:

- Windows operating system
- Visual Studio with **VB.NET / Windows Forms** support
- **.NET Framework 4.0** or a compatible installed .NET Framework version
- Microsoft **Access Database Engine / ACE OLE DB 12.0** provider
- A development environment capable of building an **x86** application

> **Important:** The project is configured for `x86` and uses `Microsoft.ACE.OLEDB.12.0`. On a modern Windows installation, make sure the matching Access Database Engine provider is installed.

### 1. Clone the repository

```bash
git clone https://github.com/<your-username>/<your-repository>.git
cd <your-repository>
```

### 2. Open the project

Open:

```text
Toddler/Toddler.vbproj
```

in Visual Studio.

### 3. Check the database configuration

The application uses:

```text
toddler.accdb
```

and the connection is configured through the project's settings/App.config.

The project is already configured to copy `toddler.accdb` to the build output directory.

### 4. Build and run

Build the solution/project in Visual Studio and run the application.

The application starts with the dashboard, from which you can enter the learning section or the protected content-management section.

## 📖 How It Works

### Learning Mode

The learning section allows users to choose one of four categories:

1. **Fruit**
2. **Vegetable**
3. **Animal**
4. **Bird**

Selecting an item loads its stored information from the Access database and displays the associated image when available.

Depending on the category, information can include:

- Name
- Varieties
- Nutrients or food
- Place
- Grow type or special characteristics
- Color
- Photo

### Content Management

The editor can select a catalog and manage its records.

Supported operations include:

- Add a new item
- Select an existing item
- Update individual fields
- Delete an item
- Select an image from the computer
- Copy the selected image into the application's `photos` directory

Supported image formats:

```text
.jpg
.png
.gif
```

When an image is selected, the application stores it under:

```text
photos/
```

and saves the relative image path in the database.

## 🗄️ Database

The project uses a Microsoft Access database:

```text
toddler.accdb
```

The application works with four main catalog tables:

```text
fruit
veg
animal
bird
```

The exact fields vary slightly between categories. Fruits and vegetables use fields such as `varieties`, `nutrients`, `place`, and `growtype`, while animals and birds use fields such as `varieties`, `food`, `place`, and `sc`.

## 🔐 Configuration & Security

Login settings are currently read from `App.config`:

```xml
<appSettings>
    <add key="ToddlerLoginUsername" value="..." />
    <add key="ToddlerLoginPassword" value="..." />
</appSettings>
```

### ⚠️ Security recommendation

Do **not** use real production credentials in a public GitHub repository.

Before publishing this project publicly:

1. Change any real credentials currently stored in `App.config`.
2. Avoid committing passwords or other secrets.
3. For a production version, move authentication to a safer mechanism instead of storing a plaintext password in configuration.
4. If a real password has already been pushed to GitHub, change/revoke it immediately.

## 🖼️ Images

The application creates the following directory when an image is added:

```text
photos/
```

For records that already reference images, make sure the referenced files are available in the expected location relative to the application executable.

If you plan to distribute the application with its sample content, include the required image files along with the database.

## 🧹 GitHub Repository Notes

The project already ignores common Visual Studio build files such as:

```text
.vs/
bin/
obj/
*.pdb
*.cache
```

The repository intentionally keeps:

```text
toddler.accdb
```

while ignoring other Access database files.

Before publishing, review the repository for:

- Passwords and API keys
- Personal information
- Unnecessary `bin/` and `obj/` files
- Sensitive database records
- Unused generated files

## ⚠️ Known Limitations

- The application depends on the legacy **.NET Framework 4.0** environment.
- It uses the **Microsoft ACE OLE DB 12.0** provider, which may require additional installation on modern systems.
- The project targets **x86**, so the database provider architecture must be compatible.
- Authentication is configuration-based and is not suitable for production security.
- The application is designed primarily for Windows desktop use.
- The Access database is a local file, so it is not intended for multi-user/server-based deployment.

## 🔮 Possible Future Improvements

- Replace plaintext/configuration-based authentication with secure password hashing.
- Upgrade the application to a modern .NET version where practical.
- Improve database error handling and validation.
- Add search functionality.
- Add audio pronunciation for learning items.
- Add quizzes and interactive activities for children.
- Add progress tracking.
- Improve accessibility and keyboard navigation.
- Add a proper deployment/installer process.
- Move from Microsoft Access to a more scalable database if multi-user support is required.

## 📄 License

No explicit open-source license is currently specified for this project.

If you intend to publish the project for others to use, add an appropriate `LICENSE` file and update this section.

## 👤 Author

**Balaguru M**

---

If you find this project useful, feel free to ⭐ the repository and contribute improvements.

# Finally, If you want work with this file do this:

1. Download this entire file
2. Save it with folder on the excat path "D:\VB-Project_Toddler"
3. Open Visual Studio 2010
4. Go to Open Project 
5. Open -> "D:\VB-Project_Medicare\Toddler\Toddler.vbproj"
6. And just run it.
7. If there any issue contact me :)
