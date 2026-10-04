# Date Information Form

## Project Overview
This C# Windows Forms project reads weekday, month, day, and year text from TextBox controls, joins the values, and displays the result.

## Controls
- `dayofweek` — weekday
- `monthtextbox` — month
- `dayofmonthtextbox` — day of month
- `yeartextbox` — year
- `dateoutput` — combined date output

## Main Code
```csharp
// Creating variables
string dayofTheweek, nameofthemonth, numericdayOM, year, concat;

// Reading values
dayofTheweek = dayofweek.Text;
nameofthemonth = monthtextbox.Text;
numericdayOM = dayofmonthtextbox.Text;
year = yeartextbox.Text;

// Combining and displaying
concat = dayofTheweek + " " + nameofthemonth + "/" +
         numericdayOM + "/" + year;

dateoutput.Text = concat;
```

## Clear Fields
```csharp
dayofweek.Text = "";
monthtextbox.Text = "";
dayofmonthtextbox.Text = "";
yeartextbox.Text = "";
dateoutput.Text = "";
```

## Close Form
```csharp
this.Close();
```

## Key Concepts
- `string` stores text.
- `.Text` reads or changes the text in a control.
- `+` joins strings; this is called concatenation.
- Assigning `""` clears a text field.
- `this.Close()` closes the current form.

## Summary
The application combines the entered weekday, month, day, and year into a single date-like string and displays it. The shown code does not validate whether the date is a real calendar date.
