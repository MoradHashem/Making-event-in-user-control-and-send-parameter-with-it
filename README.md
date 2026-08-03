# 🧮 Custom Event in UserControl with Parameter - C# WinForms

A simple C# Windows Forms project created to practice **custom events, delegates, Action<T>, and UserControls**.

The application contains a custom UserControl that allows the user to enter two numbers and calculate their sum.

After the calculation is completed, the UserControl raises a custom event and sends the calculated result as a parameter to the main form.

The main form listens to the event and displays the received result inside a `MessageBox`.

---

# 📌 Project Idea

The main purpose of this project is to understand how a **UserControl can communicate with its parent form using events**.

The user enters two numbers:

```text
Number 1: 11
Number 2: 22
```

The UserControl calculates:

```text
11 + 22 = 33
```

Then it raises a custom event and sends:

```text
33
```

as a parameter.

The main form receives the result and displays:

```text
Result = 33
```

inside a MessageBox.

---

# ✨ Features

- Custom Windows Forms `UserControl`.
- Input two numbers.
- Calculate the sum of the numbers.
- Display the result inside the UserControl.
- Create a custom event.
- Use `Action<int>` as the event delegate.
- Pass the calculation result as an event parameter.
- Subscribe to the custom event from the main form.
- Display the received result using `MessageBox`.
- Practice communication between a UserControl and its parent form.

---

# 🛠 Technologies Used

- C#
- .NET
- Windows Forms (WinForms)
- UserControl
- Delegates
- Events
- `Action<T>`
- Visual Studio

---

# 📂 Project Structure

```text
Making-Event-In-UserControl
│
├── Form1.cs
├── Form1.Designer.cs
│
├── ctrlCalculationNumbers.cs
├── ctrlCalculationNumbers.Designer.cs
│
├── Program.cs
└── README.md
```

---

# 🧩 UserControl

The project contains a custom UserControl named:

```text
ctrlCalculationNumbers
```

The control contains:

- Number 1 TextBox
- Number 2 TextBox
- Calculate Button
- Result Label

The UserControl is responsible for performing the calculation and raising the event.

---

# 📢 Custom Event

A custom event is created inside the UserControl:

```csharp
public event Action<int> OnCalculationComplete;
```

The event uses:

```csharp
Action<int>
```

This means that the event can send an integer value to its subscribers.

In this project, that integer represents the **calculation result**.

---

# ⚙️ Raising the Event

After the user clicks the **Calculate** button, the two numbers are added together:

```csharp
int Result =
    Convert.ToInt32(txtNumber1.Text) +
    Convert.ToInt32(txtNumber2.Text);
```

The result is then displayed:

```csharp
lblResult.Text = Result.ToString();
```

After that, the custom event is raised and the result is passed as a parameter:

```csharp
CalculationComplete(Result);
```

The event handler receives the calculated value.

---

# 🔔 Event Handler

The main form subscribes to the custom event from the UserControl.

When the calculation is completed, the main form receives the result and can respond to it.

For example:

```csharp
private void ctrlCalculationNumbers1_OnCalculationComplete(int Result)
{
    MessageBox.Show("Result = " + Result);
}
```

The UserControl does not need to know what Form1 will do with the result.

It simply announces:

> The calculation has completed, and this is the result.

The main form decides what action should be performed.

---

# 🔄 Application Workflow

```text
User enters Number 1
        │
        ▼
User enters Number 2
        │
        ▼
Click Calculate
        │
        ▼
UserControl calculates the result
        │
        ▼
Result displayed in UserControl
        │
        ▼
OnCalculationComplete Event
        │
        │ Result passed as parameter
        ▼
Form1 receives Result
        │
        ▼
MessageBox.Show()
        │
        ▼
     Result = 33
```

---

# ▶ Example

The user enters:

```text
Number 1 = 11
Number 2 = 22
```

Then clicks:

```text
Calculate
```

The UserControl calculates:

```text
11 + 22 = 33
```

The result appears inside the UserControl:

```text
= 33
```

At the same time, the custom event sends:

```text
33
```

to the main form.

The main form then displays:

```text
Result = 33
```

inside a MessageBox.

---

# 🧠 Main Concepts

## UserControl

A `UserControl` allows us to create a reusable custom component that can contain multiple controls and its own logic.

In this project, the calculation interface is implemented inside a UserControl.

---

## Delegate

A delegate represents a reference to a method.

The event in this project uses:

```csharp
Action<int>
```

which is a built-in generic delegate.

---

## Action<T>

`Action<T>` represents a method that:

- Receives a parameter.
- Does not return a value.

In this project:

```csharp
Action<int>
```

means that the event sends one `int` parameter.

That parameter is the calculation result.

---

## Event

The event allows the UserControl to notify another part of the application when something happens.

In this project:

```text
Something happened:
Calculation completed.

Data sent:
Calculation result.
```

The UserControl raises the event, and Form1 listens to it.

---

# 🎯 Learning Objectives

By completing this project, I learned how to:

- Create a custom UserControl in C# WinForms.
- Add controls and logic inside a UserControl.
- Create a custom event.
- Use the built-in `Action<T>` delegate.
- Create an event that carries a parameter.
- Raise an event from a UserControl.
- Pass calculation results through an event.
- Subscribe to a UserControl event from Form1.
- Receive event parameters inside an event handler.
- Display received data using a MessageBox.
- Understand communication between UserControls and Forms.
- Understand the relationship between delegates and events.

---

# 📅 Learning Progress

### Lesson: Creating Events in UserControls and Passing Parameters

Today I learned how to create a **custom event inside a UserControl** and send data through that event.

I created a UserControl that accepts two numbers and calculates their sum.

After the calculation is completed, the UserControl raises the:

```csharp
OnCalculationComplete
```

event and sends the calculated result as an `int` parameter.

The main form listens to this event, receives the result, and displays it using a MessageBox.

This lesson helped me understand how **events can be used to communicate between reusable UserControls and their parent forms without tightly coupling them together**.

---

# 🚀 How to Run

1. Open the project in Visual Studio.
2. Build the solution.
3. Run the application.
4. Enter the first number.
5. Enter the second number.
6. Click **Calculate**.
7. The result will appear inside the UserControl.
8. The `OnCalculationComplete` event will be raised.
9. Form1 will receive the result.
10. A MessageBox will display the calculated result.

---

# 👨‍💻 Author

**Morad Mahmoud Ahmed Qiad Hashem**

Computer Science Student

---

# 📄 License

This project is created for educational and learning purposes.

---

# ⭐ Support

If you found this project useful, consider giving it a ⭐ on GitHub.
