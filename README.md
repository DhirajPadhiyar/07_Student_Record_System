# 🎓 Student Record System

A simple ASP.NET Core MVC project that demonstrates how to use Models and Strongly Typed Views to display student information in multiple UI formats.

## 📚 Concepts Covered

- ASP.NET Core MVC
- Models
- Controllers
- Strongly Typed Views
- List<T>
- Data Passing from Controller to View
- Razor Syntax
- Bootstrap Styling
- Conditional Rendering
- Table View
- Card View

---

## 🚀 Features

### Student Information Table

- Displays student records in a Bootstrap table
- Responsive layout
- Striped rows
- Dark table header

### Student Information Cards

- Displays the same student data using Bootstrap cards
- Clean and modern UI

### Conditional Badge Logic

Students with age 22 or above receive a special badge:

```csharp
@if(item.Age >= 22)
{
    <span class="badge bg-success">Brilliant</span>
}
```

---

## 🏗 Project Structure

```text
Models
 └── Student.cs

Controllers
 └── StudentController.cs

Views
 └── Student
      └── StudentInfo.cshtml
```

---

## 📋 Student Model

```csharp
public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }
    public string Email { get; set; }
}
```

---

## 📷 Screenshots

### Student Information Table & Cards

<img width="2560" height="1922" alt="localhost_7277_Student_StudentInfo(Nest Hub Max)" src="https://github.com/user-attachments/assets/5265e068-29dc-4820-b1e1-000b4b69a149" />




---

## 💡 Learning Outcome

After completing this project, I learned:

- How Models work in MVC
- How Strongly Typed Views receive data
- How to display List<T> data
- How to use foreach loops in Razor Views
- How to create Table and Card layouts
- How to apply Bootstrap styling
- How to add conditional UI logic

---

## 🛠 Technologies Used

- ASP.NET Core MVC
- C#
- Razor Views
- Bootstrap 5
- HTML
- CSS

---

## 📈 Project Status

✅ Completed

---

## 👨‍💻 Author

Dhiraj Padhiyar
